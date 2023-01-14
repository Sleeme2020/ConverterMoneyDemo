using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassModel
{
    public class Bd
    {
        public List<Valute> Valutes { get; set; }
        private List<Divided> Divideds { get; set; }

        public Bd() => initial();

        public double Convet(double value,Valute t, Valute t2)
        {
            
                Divided divided = Divideds.Where(u=> 
                (u.Valute1.Name == t.Name 
                &&  u.Valute2.Name == t2.Name))
                    .First();
            if(divided.Valute1.Name == t.Name)
            {
                return value * divided.value;
            }
            else
            {
                return value / divided.value;
            }    
            
        }

        private void initial()
        {
            Valutes= new List<Valute>();
            Valutes.AddRange(new Valute[] {
                new Valute(){ Name="Dollar" },
                new Valute(){ Name="Euro" },
                new Valute(){ Name="uani" },
                new Valute(){ Name="rub" }
            });
            Divideds = new List<Divided>();
            Divideds.AddRange(new Divided[]
            {
                new Divided(){ Valute1 = Valutes[0],Valute2 = Valutes[3],value = 70 },
                new Divided(){ Valute1 = Valutes[1],Valute2 = Valutes[3],value = 75 },
                new Divided(){ Valute1 = Valutes[2],Valute2 = Valutes[3],value = 10 }
            });
        }
    }
}
