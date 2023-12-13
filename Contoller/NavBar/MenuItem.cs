using REMAS.Module;
using REMAS;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

public class MenuItem
{
    public List<NavBarItem> listMenu;
    public List<NavBarItem> listMenuDb;
    string sql, sUserCd = REMAS.Properties.Settings.Default.User;
    RunQuery qu_All;
    DataTable myData, myData2;
    public MenuItem()
    {
        listMenuDb = new List<NavBarItem>();

        // Add MainRoot
        sql = " Select ModGrpCd, ModGrpName, Picture from SystemGroup Where ModGrpCd in (Select l.MainRoot from UserGroupRights gr " +
              " Left Join SystemList l on gr.ProgCd = l.ProgCd and l.Register = 'True' " +
              " Where GroupCd = (Select GroupCd from SystemUser Where NIK = '" + sUserCd + "') and AllowAccess = 1 Group By l.MainRoot) " +
              " Order By SeqNo ";
        qu_All = new RunQuery();
        myData = qu_All.OpenAdoQuery(sql);
        if (myData.Rows.Count > 0)
        {
            for (int n = 0; n <= myData.Rows.Count - 1; n++)
            {
                NavBarItem mainroot = new NavBarItem();
                mainroot.ID = n + 1;
                mainroot.Root = myData.Rows[n]["ModGrpCd"].ToString().Trim();
                mainroot.Text = myData.Rows[n]["ModGrpName"].ToString().Trim();
                string sPicName = myData.Rows[n]["Picture"].ToString().Trim();
                mainroot.Icon = new ItemIcon
                {
                    Default = (System.Drawing.Image)REMAS.Properties.Resources.ResourceManager.GetObject(sPicName),
                    Hover = (System.Drawing.Image)REMAS.Properties.Resources.ResourceManager.GetObject(sPicName),
                    Selected = (System.Drawing.Image)REMAS.Properties.Resources.ResourceManager.GetObject(sPicName)
                };
                // Add Root
                string[] sRoots = { "TRX", "MSR", "RPT", };
                string[] sTexts = { "Transaksi", "Master", "Report", };
                mainroot.Childs = new List<NavBarItem>();

                for (int m = 0; m < sRoots.Length; m++)
                {
                    NavBarItem root = new NavBarItem();
                    root.ID = (mainroot.ID * 1000) + (m + 1);
                    root.ParentID = mainroot.ID;
                    root.Root = sRoots[m].ToString();
                    root.Text = sTexts[m].ToString();
                    root.Height = 30;

                    // Add SubChilds -->
                    sql = " Select l.* from UserGroupRights gr " +
                          " Left Join SystemList l on gr.ProgCd = l.ProgCd and l.Register = 'True'" +
                          " Where GroupCd = (Select GroupCd from SystemUser Where NIK = '" + sUserCd + "') " +
                          " and AllowAccess = 1 and l.MainRoot = '" + mainroot.Root + "' and l.SubRoot = '" + root.Root + "' Order By l.SeqNo";
                    qu_All = new RunQuery();
                    myData2 = qu_All.OpenAdoQuery(sql);

                    root.Childs = new List<NavBarItem>();
                    if (myData2.Rows.Count > 0)
                    {

                        for (int i = 0; i <= myData2.Rows.Count - 1; i++)
                        {
                            NavBarItem subchilds = new NavBarItem();
                            subchilds.ID = root.ID * 10 + (i + 1);
                            subchilds.ParentID = root.ID;
                            subchilds.Root = myData2.Rows[i]["ProgName"].ToString().Trim();
                            subchilds.Text = myData2.Rows[i]["MenuName"].ToString().Trim();
                            subchilds.Height = 30;
                            subchilds.LeftChild = 20;
                            root.Childs.Add(subchilds);
                        }
                        mainroot.Childs.Add(root);
                    }                    
                }
                listMenuDb.Add(mainroot);
            }
        }

        

    }
}
