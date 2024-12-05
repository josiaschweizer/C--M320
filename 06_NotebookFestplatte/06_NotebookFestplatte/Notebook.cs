using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Festplatte
{
    private Notebook Notebook { get; set; }

    public Festplatte()
    {

    }

    public Festplatte(Notebook notebook)
    {
        this.Notebook = notebook;
    }

    public void anderesNotebook(Notebook notebook)
    {
        this.Notebook = notebook;
    }

}
