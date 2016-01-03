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
        public DraggingPicBox picBox = null;
        public Shmot(string FilePath, ShmotCategory sc)
        {
            PathPhoto = FilePath;
            Name = Path.GetFileName(FilePath);
            category = sc;
        }

        public void DeletePicBox()
        {
            if (picBox != null)
            {
                picBox.Free();
                picBox = null;
            }
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
                    TreeNode shNode = scNode.Nodes.Add(sh.Name);
                    shNode.Tag = sh as Object;
                }
            }
        }

        internal string GetImagePath(Object p)
        {
            string result = String.Empty;
            if (p is Shmot)
            {
                Shmot sh = p as Shmot;
                result = sh.PathPhoto;
            }
            return result;
        }

        Shmot CurShmot;
        internal void SetCurShmot(object p)
        {
            if (p is Shmot)
            {
                CurShmot = p as Shmot;
            }
        }

        internal void AppendImage(Control control)
        {
            CurShmot.picBox = new DraggingPicBox(CurShmot.PathPhoto, control);
        }

        internal void RemoveImage(PictureBox pbMainPhoto)
        {
            if (CurShmot.picBox != null)
            {
                CurShmot.DeletePicBox();
            }
        }

        public void ClearAll()
        {
            foreach (ShmotCategory sc in CatList)
            {
                foreach (Shmot sh in sc.list)
                {
                    sh.DeletePicBox();
                }
            }
        }
    }
}
