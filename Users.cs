using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documentation_notes_cours
{
    /// <summary>
    /// Classe qui gère les utilisateurs
    /// <remarks>Une remark sur ma classe</remarks>
    /// </summary>
    public class Users
    {
        /// <summary>
        /// Propriété <c>Username</c>
        /// <value>Obtient ou définit le nom d'utilisateur</value>
        /// </summary>
        public string Username { get; set; }
        public string Password { get; set; }
        /// <summary>
        /// Constructeur de la classe Users
        /// </summary>
        /// <param name="username">Nom d'utilisateur</param>
        /// <param name="pasword">Mot de passe utilisateur</param>
        public Users(string username, string pasword)
        {
            Username = username;
            Password = Password;
        }
        /// <summary>
        /// Fonction d'informations d'utilisateur
        /// </summary>
        /// <returns>Renvoie des informations d'utilisateurs de type string</returns>
        public string Information()
        {
            return "Username: " + Username + " Password: " + Password;
        }
        /// <summary>
        /// Afficher les ionformations de l'utilisateur dans une boîte de message
        /// </summary>
        /// <exemple>Affiche("Username : ANCRE Password: 123")/exemple>
        public void Affiche()
        {
            System.Windows.Forms.MessageBox.Show(Information());
        }
    }
}
