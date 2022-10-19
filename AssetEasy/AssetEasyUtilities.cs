using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using Wisej.Web;

namespace AssetEasy
{
    public class Utilities
    {

        public static bool DataColumnIsNumeric(DataColumn col)
        {
            if (col == null)
                return false;
            // Make this const
            var numericTypes = new[] { typeof(Byte), typeof(Decimal), typeof(Double),
        typeof(Int16), typeof(Int32), typeof(Int64), typeof(SByte),
        typeof(Single), typeof(UInt16), typeof(UInt32), typeof(UInt64)};
            return numericTypes.Contains(col.DataType);
        }

        
        public static void TreeViewLoad(ref TreeView treeView, object  parentId, TreeNode parentNode, DataTable dataTable, string IDColumnName, string parentIDColumnName, string textColumnName, string keyColumName = "",string sort="")
        {

            if (dataTable.Rows.Count == 0)
                return;

            TreeNode childNode;
            string query = "";
           
            if (keyColumName == "")
                keyColumName = IDColumnName;


            if (parentId != DBNull.Value)
            {
                if (DataColumnIsNumeric(dataTable.Columns[parentIDColumnName]) == true)
                {
                    query = parentIDColumnName + "=" + parentId;
                }
                else
                {
                    query = parentIDColumnName + "='" + parentId+"'";
                }
            }
            else
            {
                if (DataColumnIsNumeric(dataTable.Columns[parentIDColumnName]) == true)
                {
                    query = parentIDColumnName + " is null or " + parentIDColumnName + "=0";
                }
                else
                {
                    query = parentIDColumnName + " is null or " + parentIDColumnName + "=''";
                }
                
            }


            foreach (DataRow dr in dataTable.Select(query,sort))
            {
                TreeNode t = new TreeNode();
                t.Text = dr[keyColumName].ToString() + " - " + dr[textColumnName].ToString();
                t.Name = dr[IDColumnName ].ToString();
                //t.Tag  = dr[keyColumName].ToString(); 
                t.Tag = dataTable.Rows.IndexOf(dr);
                if (parentNode == null)
                {
                    treeView.Nodes.Add(t);
                    childNode = t;
                }
                else
                {
                    parentNode.Nodes.Add(t);
                    childNode = t;
                }

                TreeViewLoad(ref treeView, Convert.ToInt32(dr[IDColumnName].ToString()), childNode, dataTable, IDColumnName, parentIDColumnName, textColumnName, keyColumName);
            }
            
        }
        public static void TreeViewComboBoxLoad(ref TreeViewComboBox treeView, object parentId, TreeNode parentNode, DataTable dataTable, string IDColumnName, string parentIDColumnName, string textColumnName, string keyColumName = "", string sort="")
        {
            TreeNode childNode;
            string query = "";
           
            if (keyColumName == "")
                keyColumName = IDColumnName;


            if (parentId != DBNull.Value)
            {
                if (DataColumnIsNumeric(dataTable.Columns[parentIDColumnName]) == true)
                {
                    query = parentIDColumnName + "=" + parentId;
                }
                else
                {
                    query = parentIDColumnName + "='" + parentId + "'";
                }
            }
            else
            {
                if (DataColumnIsNumeric(dataTable.Columns[parentIDColumnName]) == true)
                {
                    query = parentIDColumnName + " is null or " + parentIDColumnName + "=0";
                }
                else
                {
                    query = parentIDColumnName + " is null or " + parentIDColumnName + "=''";
                }

            }

            foreach (DataRow dr in dataTable.Select(query, sort))
            {
                TreeNode t = new TreeNode();
                t.Text = dr[keyColumName].ToString() + " - " + dr[textColumnName].ToString();
                t.Name = dr[IDColumnName].ToString();
                //t.Tag  = dr[keyColumName].ToString(); 
                t.Tag = dataTable.Rows.IndexOf(dr);
                if (parentNode == null)
                {
                    treeView.Nodes.Add(t);
                    childNode = t;
                }
                else
                {
                    parentNode.Nodes.Add(t);
                    childNode = t;
                }

                TreeViewComboBoxLoad(ref treeView, Convert.ToInt32(dr[IDColumnName].ToString()), childNode, dataTable, IDColumnName, parentIDColumnName, textColumnName, keyColumName);
            }

        }

        public static TreeNode GetTreeNodeByName(TreeNodeCollection treeNodes, string nodeName)
        {

            TreeNode[] aFindResult = treeNodes.Find(nodeName, true);
            TreeNode tvnRet = null;

            for (int j = 0; j < aFindResult.Length; j++)
            {
                if (aFindResult[j].Name == nodeName)
                {
                    tvnRet = aFindResult[j];
                    break;
                }
            }

            return tvnRet;

        }

        private static Random GetRandom_staticRandomGenerator;

        static Utilities()
        {
            Utilities.GetRandom_staticRandomGenerator = new Random();
        }

        public static bool DesignMode()
        {
            return System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime;
        }

   

        public static string EnumDescription(Enum EnumConstant)
        {
            string str;
            FieldInfo fi = EnumConstant.GetType().GetField(EnumConstant.ToString());
            DescriptionAttribute[] aattr = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            str = (aattr.Length == 0 ? EnumConstant.ToString() : aattr[0].Description);
            return str;
        }

        public static DataTable EnumToDataTable(Type enumType, Utilities.EnumToDataTableValueItem valueitem, Utilities.EnumToDataTableDisplayItem displayitem)
        {
            string ID;
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(string));
            table.Columns.Add("Desc", typeof(string));
            Utilities.EnumItem enumItem = new Utilities.EnumItem();
            Dictionary<int, Utilities.EnumItem> enumItems = new Dictionary<int, Utilities.EnumItem>();
            Dictionary<int, int> values = new Dictionary<int, int>();
            int index = 0;
            string[] names = Enum.GetNames(enumType);
            for (int num = 0; num < (int)names.Length; num++)
            {
                enumItem = new Utilities.EnumItem()
                {
                    Name = names[num]
                };
                enumItems.Add(index, enumItem);
                index++;
            }
            index = 0;
            foreach (int i in Enum.GetValues(enumType))
            {
                enumItems[index].Value = i.ToString();
                values.Add(index, i);
                index++;
            }
            FieldInfo[] info = enumType.GetFields(BindingFlags.Static | BindingFlags.Public);
            for (int i = 0; i < (int)info.Length; i++)
            {
                enumItem = enumItems[i];
                foreach (CustomAttributeData item in info[i].CustomAttributes)
                {
                    if (item.AttributeType.Name == "DescriptionAttribute")
                    {
                        CustomAttributeTypedArgument customAttributeTypedArgument = item.ConstructorArguments[0];
                        enumItem.Description = customAttributeTypedArgument.ToString().Replace("\"", "");
                    }

                    if (item.AttributeType.Name == "DefaultValueAttribute")
                    {
                        CustomAttributeTypedArgument customAttributeTypedArgument = item.ConstructorArguments[0];
                        enumItem.Value = customAttributeTypedArgument.ToString().Replace("\"", "");
                    }
                }
            }
            for (int i = 0; i < enumItems.Count; i++)
            {
                enumItem = enumItems[i];
                string DESCRIPTION = "";
                ID = (valueitem != Utilities.EnumToDataTableValueItem.Name ? enumItem.Value : enumItem.Name);
                switch (displayitem)
                {
                    case Utilities.EnumToDataTableDisplayItem.Name:
                        {
                            DESCRIPTION = enumItem.Name;
                            break;
                        }
                    case Utilities.EnumToDataTableDisplayItem.Value:
                        {
                            break;
                        }
                    case Utilities.EnumToDataTableDisplayItem.Description:
                        {
                            DESCRIPTION = enumItem.Description;
                            break;
                        }
                    case Utilities.EnumToDataTableDisplayItem.ValueName:
                        {
                            DESCRIPTION = string.Concat(ID, "- ", enumItem.Name);
                            break;
                        }
                    case Utilities.EnumToDataTableDisplayItem.ValueDescription:
                        {
                            DESCRIPTION = string.Concat(ID, "- ", enumItem.Description);
                            break;
                        }
                    default:
                        {
                            goto case Utilities.EnumToDataTableDisplayItem.Value;
                        }
                }
                table.Rows.Add(new object[] { ID, DESCRIPTION });
            }
            return table;
        }

        public static DataTable EnumToDataTable(Type enumType, Utilities.EnumToDataTableDisplayItem  valueitem, Utilities.EnumToDataTableDisplayItem displayitem)
        {
            string ID;
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(string));
            table.Columns.Add("Desc", typeof(string));
            Utilities.EnumItem enumItem = new Utilities.EnumItem();
            Dictionary<int, Utilities.EnumItem> enumItems = new Dictionary<int, Utilities.EnumItem>();
            Dictionary<int, int> values = new Dictionary<int, int>();
            int index = 0;
            string[] names = Enum.GetNames(enumType);
            for (int num = 0; num < (int)names.Length; num++)
            {
                enumItem = new Utilities.EnumItem()
                {
                    Name = names[num]
                };
                enumItems.Add(index, enumItem);
                index++;
            }
            index = 0;
            foreach (int i in Enum.GetValues(enumType))
            {
                enumItems[index].Value = i.ToString();
                values.Add(index, i);
                index++;
            }
            FieldInfo[] info = enumType.GetFields(BindingFlags.Static | BindingFlags.Public);
            for (int i = 0; i < (int)info.Length; i++)
            {
                enumItem = enumItems[i];
                foreach (CustomAttributeData item in info[i].CustomAttributes)
                {
                    if (item.AttributeType.Name == "DescriptionAttribute")
                    {
                        CustomAttributeTypedArgument customAttributeTypedArgument = item.ConstructorArguments[0];
                        enumItem.Description = customAttributeTypedArgument.ToString().Replace("\"", "");
                    }
                    if (item.AttributeType.Name == "DefaultValueAttribute")
                    {
                        CustomAttributeTypedArgument customAttributeTypedArgument = item.ConstructorArguments[0];
                        enumItem.Value  = customAttributeTypedArgument.ToString().Replace("\"", "");
                    }

                }
            }
            for (int i = 0; i < enumItems.Count; i++)
            {
                enumItem = enumItems[i];
                string DESCRIPTION = "";
                ID = (valueitem != Utilities.EnumToDataTableDisplayItem.Name ? enumItem.Name  : enumItem.Name);
                switch (displayitem)
                {
                    case Utilities.EnumToDataTableDisplayItem.Name:
                        {
                            DESCRIPTION = enumItem.Name;
                            break;
                        }
                    case Utilities.EnumToDataTableDisplayItem.Value:
                        {
                            break;
                        }
                    case Utilities.EnumToDataTableDisplayItem.Description:
                        {
                            DESCRIPTION = enumItem.Description;
                            break;
                        }
                    case Utilities.EnumToDataTableDisplayItem.ValueName:
                        {
                            DESCRIPTION = string.Concat(ID, "- ", enumItem.Name);
                            break;
                        }
                    case Utilities.EnumToDataTableDisplayItem.ValueDescription:
                        {
                            DESCRIPTION = string.Concat(ID, "- ", enumItem.Description);
                            break;
                        }
                    default:
                        {
                            goto case Utilities.EnumToDataTableDisplayItem.Value;
                        }
                }
                table.Rows.Add(new object[] { ID, DESCRIPTION });
            }
            return table;
        }

        public static TreeNode FindNodeByKey(TreeView Treeview, string SearchKey)
        {
            TreeNode treeNode;
            try
            {
                TreeNode[] arr = Treeview.Nodes.Find(SearchKey, true);
                if (arr.Length != 0)
                {
                    treeNode = arr[0];
                    return treeNode;
                }
            }
            catch
            {
                treeNode = null;
                return treeNode;
            }
            treeNode = null;
            return treeNode;
        }

        public static int GetRandom(int min, int max)
        {
            max++;
            return Utilities.GetRandom_staticRandomGenerator.Next((min > max ? max : min), (min > max ? min : max));
        }

        public static void GetTreeViewCheckedNodes(TreeNodeCollection nodes, List<TreeNode> list)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Checked)
                {
                    list.Add(node);
                }
                Utilities.GetTreeViewCheckedNodes(node.Nodes, list);
            }
        }

        public static void GetTreeViewNodes(TreeNodeCollection nodes, List<TreeNode> list)
        {
            foreach (TreeNode node in nodes)
            {
                list.Add(node);
                Utilities.GetTreeViewCheckedNodes(node.Nodes, list);
            }
        }

        public static DataTable GetTrueFalseDataTableForComboBox(string TrueDescription = "True", string FalseDescription = "False")
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(bool));
            table.Columns.Add("Desc", typeof(string));
            table.Rows.Add(new object[] { false, FalseDescription });
            table.Rows.Add(new object[] { true, TrueDescription });
            return table;
        }

        public static DataTable GetYesNoDataTableForComboBox(string YesDescription = "Yes", string NoDescription = "No")
        {
            return Utilities.GetTrueFalseDataTableForComboBox(YesDescription, NoDescription);
        }


        public static System.Drawing.Image SafeImageFromFile(string path)
        {

            byte[] bytesArr = null;
            bytesArr = System.IO.File.ReadAllBytes(path);

            System.IO.MemoryStream memstr = new System.IO.MemoryStream(bytesArr);
            System.Drawing.Image img = System.Drawing.Image.FromStream(memstr);
            return img;
        }

        public static string NewGUID()
        {
            Guid guid = Guid.NewGuid();
            string upper = guid.ToString().Replace("-", "").ToUpper();
            return upper;
        }

        public static void Reflection_GetFields(Type t)
        {
            Console.WriteLine("***** Fields *****");
            FieldInfo[] fields = t.GetFields();
            for (int i = 0; i < (int)fields.Length; i++)
            {
                Console.WriteLine("->{0}", fields[i].Name);
            }
            Console.WriteLine("");
        }

        public static void Reflection_GetProperties(Type t)
        {
            Console.WriteLine("***** Properties *****");
            PropertyInfo[] properties = t.GetProperties();
            for (int i = 0; i < (int)properties.Length; i++)
            {
                Console.WriteLine("->{0}", properties[i].Name);
            }
            Console.WriteLine("");
        }

        public static string Reflection_GetValidFilename(string Filename)
        {
            string regex = string.Format("[{0}]", Regex.Escape(new string(Path.GetInvalidFileNameChars())));
            Regex removeInvalidChars = new Regex(regex, RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.CultureInvariant);
            return regex;
        }

        public static string SequenceFrom(string value)
        {
            char chr;
            int i = 0;
            int c = 0;
            for (i = value.Length; i >= 1; i--)
            {
                c = Convert.ToInt32(value[i - 1]);
                if ((c < 48 ? true : c > 57))
                {
                    if ((c < 65 ? false : c <= 90))
                    {
                        if ((c < 65 ? false : c <= 89))
                        {
                            c++;
                            string str = value.Remove(i - 1, 1);
                            chr = (char)c;
                            value = str.Insert(i - 1, chr.ToString());
                            break;
                        }
                        else if (c == 90)
                        {
                            c = 65;
                            string str1 = value.Remove(i - 1, 1);
                            chr = (char)c;
                            value = str1.Insert(i - 1, chr.ToString());
                        }
                    }
                }
                else if ((c < 48 ? false : c <= 56))
                {
                    c++;
                    string str2 = value.Remove(i - 1, 1);
                    chr = (char)c;
                    value = str2.Insert(i - 1, chr.ToString());
                    break;
                }
                else if (c == 57)
                {
                    c = 48;
                    string str3 = value.Remove(i - 1, 1);
                    chr = (char)c;
                    value = str3.Insert(i - 1, chr.ToString());
                }
            }
            return value;
        }

        public static string SequenceFrom(string value, string SequenceMask)
        {
            char chr;
            bool flag;
            int x = 0;
            int i = 0;
            int c = 0;
            string a = null;
            x = value.Length;
            SequenceMask = SequenceMask.ToUpper();
            if (value.Length < SequenceMask.Length)
            {
                value = new string(' ', SequenceMask.Length);
            }
            for (i = x; i >= 1; i--)
            {
                a = SequenceMask.Substring(i - 1, 1);
                if (a != "F")
                {
                    c = Convert.ToInt32(value[i - 1]);
                    string str = a;
                    if (str != null)
                    {
                        if (str != "0")
                        {
                            goto Label2;
                        }
                        if ((c < 48 ? true : c > 56))
                        {
                            if (c != 57)
                            {
                                c = 48;
                                string str1 = value.Remove(i - 1, 1);
                                chr = (char)c;
                                value = str1.Insert(i - 1, chr.ToString());
                            }
                            else
                            {
                                c = 48;
                                string str2 = value.Remove(i - 1, 1);
                                chr = (char)c;
                                value = str2.Insert(i - 1, chr.ToString());
                            }
                            goto Label0;
                        }
                        else
                        {
                            c++;
                            string str3 = value.Remove(i - 1, 1);
                            chr = (char)c;
                            value = str3.Insert(i - 1, chr.ToString());
                            break;
                        }
                    }
                Label2:;
                    flag = (c < 65 ? false : c <= 89);
                    if (flag)
                    {
                        c++;
                        string str4 = value.Remove(i - 1, 1);
                        chr = (char)c;
                        value = str4.Insert(i - 1, chr.ToString());
                        break;
                    }
                    else if (c != 90)
                    {
                        c = 65;
                        string str5 = value.Remove(i - 1, 1);
                        chr = (char)c;
                        value = str5.Insert(i - 1, chr.ToString());
                    }
                    else
                    {
                        c = 65;
                        string str6 = value.Remove(i - 1, 1);
                        chr = (char)c;
                        value = str6.Insert(i - 1, chr.ToString());
                    }
                Label0:;
                }
            }
            return value;
        }

        public static void PreviewDocument(string filename, Control parent)
        {

            //Wisej.Web.Ext.PrintPreview.PrintPreviewControl v = new Wisej.Web.Ext.PrintPreview.PrintPreviewControl();
            //v.Parent = parent;
            

            //try
            //{
            //    StreamReader streamToPrint = new StreamReader
            //       (filename);
            //    try
            //    {
            //        System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
            //        v.Document = pd;
            //        v.Show();
            //    }
            //    finally
            //    {
            //        streamToPrint.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}



        }



        public static void PrintDocument(string filename)
        {
            try
            {
                StreamReader streamToPrint = new StreamReader
                   (filename);
                try
                {
                    
                    System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
                    pd.Print();
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SetDataGridViewCurrentRow(ref DataGridView DataGridView, int Index)
        {
            if (DataGridView != null)
            {
                try
                {
                    DataGridView.CurrentCell = DataGridView.Rows[Index].Cells[0];
                }
                catch
                {
                }
            }
        }

        //public static void SetDataGridViewDoubleBuffered(DataGridView dgv, bool setting)
        //{
        //    PropertyInfo pi = dgv.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
        //    pi.SetValue(dgv, setting, null);
        //}

        public static void SetDbObjectCurrentRowFromDataGridView(ref BasicDAL.DbObject DBObject, DataGridView DataGridView)
        {
            if (DataGridView != null)
            {
                if (DataGridView.CurrentCell != null)
                {
                    if (DBObject != null)
                    {
                        try
                        {
                            DBObject.MoveTo(DataGridView.CurrentCell.RowIndex);
                        }
                        catch
                        {
                        }
                    }
                }
            }
        }

   
        public static string ValueSubString(string Value, int StartPos, int EndPos)
        {
            string str;
            if (StartPos < 1)
            {
                str = "";
            }
            else if (EndPos < 1)
            {
                str = "";
            }
            else if (EndPos >= StartPos)
            {
                if (EndPos > Value.Length)
                {
                    EndPos = Value.Length;
                }
                str = (StartPos <= Value.Length ? Value.Substring(StartPos - 1, EndPos - StartPos + 1) : "");
            }
            else
            {
                str = "";
            }
            return str;
        }

        private class EnumItem
        {
            public string Name = "";
            public string Value = "";
            public string Description = "";
            public EnumItem()
            {
            }
        }

        public enum EnumToDataTableDisplayItem
        {
            Name,
            Value,
            Description,
            ValueName,
            ValueDescription

        }

        public enum EnumToDataTableValueItem
        {
            Name,
            Value
                
            
        }

        public class TextBoxStreamWriter : TextWriter
        {
            private TextBox _output = null;

            public override Encoding Encoding
            {
                get
                {
                    return Encoding.UTF8;
                }
            }

            public TextBoxStreamWriter(TextBox output)
            {
                this._output = output;
            }

            public override void Write(char value)
            {
                base.Write(value);
                this._output.AppendText(value.ToString());
            }
        }
    }

  

}