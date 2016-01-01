using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace PlatiaApp
{
    class Shmot
    {
        public string Name;
        public string PathPhoto;
        public ShmotCategory category;
        public Shmot(string FilePath, ShmotCategory sc)
        {
            PathPhoto = FilePath;
            Name = Path.GetFileName(FilePath);
            category = sc;
        }

    }

    class Shmots : List<Shmot>
    {
    }

    class ShmotCategory
    {
        public string Name;
        public Shmots list = new Shmots();
        public ShmotCategory(string LName)
        {
            this.Name = LName;
        }
    }

    class ShmotCategoryList : List<ShmotCategory>
    {
        /*public void Add(string LName)
        {
            ShmotCategory sc = new ShmotCategory(LName);
            sc.Name = LName;
            Add(sc);
        }*/
    }

    class ClothesList
    {
        ShmotCategoryList CatList = new ShmotCategoryList();

        public void ReadFromFolder(string folderPath)
        {
            foreach (string DirName in Directory.GetDirectories(folderPath))
            {
                ShmotCategory sc = new ShmotCategory(Path.GetFileName(DirName));
                CatList.Add(sc);
                foreach (string FileName in Directory.GetFiles(DirName))
                {
                    Shmot sh = new Shmot(FileName, sc);
                    sc.list.Add(sh);
                }
            }
        }

        public void FillTreeNodes(TreeNodeCollection tv)
        {
            TreeNode root = tv.Add("Root");
            foreach (ShmotCategory sc in CatList)
            {
                TreeNode scNode = new TreeNode(sc.Name);
                root.Nodes.Add(scNode);
                foreach (Shmot sh in sc.list)
                {
                    scNode.Nodes.Add(sh.Name);
                }
            }
        }
    }
}
