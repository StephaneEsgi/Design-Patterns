using System;
using static System.Console;

namespace TemplateMethod
{
    public class MainActivity : Activity{

        public override void OnResume(){
            base.OnResume();

            WriteLine("[MainActivity] Nous faisons une opération supplémentaire dans le OnResume() !");
        }

        public override void OnDestroy(){
            WriteLine("[MainActivity] On s'assure par exemple d'avoir bien tout libéré !");

            base.OnDestroy();
        }

        // ici on définit quelle sera la ressource fournit à l'algorithme présent dans la classe mère
        public override string GetLayoutRes(){
            return "test";
        }
    }
}