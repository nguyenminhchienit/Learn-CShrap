using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TreeNodeGUI
{
    public partial class Form1 : Form
    {
        string path = @"E:\";
        public Form1()
        {
            InitializeComponent();

            //LoadTreeView();

            if (Directory.Exists(path)){
                TreeNode root = new TreeNode() { Text = path };
                treeView1.Nodes.Add(root);
                LoadExploxer(root);
            }
        }

        void LoadExploxer(TreeNode root)
        {
            if(root == null)
            {
                return;
            }

            try
            {
                var folderList = new DirectoryInfo(root.Text).GetDirectories();

                if(folderList.Count() == 0)
                {
                    return;
                }

                foreach(DirectoryInfo folder in folderList)
                {
                    if (Directory.Exists(folder.FullName))
                    {
                        TreeNode node = new TreeNode() { Text = folder.FullName };
                        root.Nodes.Add(node);
                        LoadExploxer(node);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        void LoadTreeView()
        {

            treeView1.CheckBoxes = true;
            TreeNode root1 = new TreeNode();
            root1.Text = "Node 1";

            TreeNode node1 = new TreeNode();
            node1.Text = "Sub Node 1";

            root1.Nodes.Add(node1);


            TreeNode root2 = new TreeNode();
            root2.Text = "Node 2";

            treeView1.Nodes.Add(root1);
            treeView1.Nodes.Add(root2);

        }

    }
}
