using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Notebook
{
    private List<Festplatte> festplatteList { get; set; }

    public Notebook()
    {  
        festplatteList = new List<Festplatte>();
    }

    public Notebook(Festplatte festplatte)
    {
        festplatteList = new List<Festplatte>();
        festplatteList.Add(festplatte);
    }

    public Notebook(List<Festplatte> list)
    {
        if (list == null)
        {
            throw new ArgumentNullException("list");
        }
        else if (list.Count <= 3)
        {
            festplatteList = list;
        }
        else
        {
            festplatteList = new List<Festplatte>();
            for (int i = list.Count - 1; i < 3; i++)
            {
                festplatteList[i] = list[i];
            }
        }
    }

    public void festplatteHinzufügen(Festplatte festplatte)
    {
        if(festplatteList.Count <= 2)
        {
            festplatteList.Add(festplatte);
        }
    }
}
