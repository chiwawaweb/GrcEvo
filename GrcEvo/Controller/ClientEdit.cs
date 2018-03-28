using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrcEvo.DAL;
using GrcEvo.DTO;

namespace GrcEvo.Controller
{
    public class ClientEdit : Forms.ClientEditForm
    {
        public static bool erreurs;

        public void SaveData()
        {
            /* Vérification des données */
            //bool erreurs;
            string errMsg = "Votre saisie comporte des erreurs : \n\n";

            if (nomClient.Length < 2)
            {
                erreurs = true;
                errMsg = "- Nom du client incorrect \n";
            }

            AfficheErreurs();

            
            Console.WriteLine("Après (2) " + nomClient);
        }
    }
}
