using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TestPatterns.Classes
{
    class clsPrincipale
    {
        SqlConnection con = null; // Etablir la connexion a la base de donnees 
        SqlCommand cmd = null; // Executer une commande dans une base de donnees
        SqlDataAdapter dt = null; // Lire les donnees 
        SqlDataReader dr = null; // LIre les donnees ligne apres ligne
        DataSet ds = null; // convertir les donnees sous forme d'un tableau

        void innitialiseConnection()
        {
            con = new SqlConnection(clsConnexion.chemin);
        }

        public static clsPrincipale _instance = null;

        public static clsPrincipale GetInstance()
        {
            if (_instance == null)
                _instance = new clsPrincipale();
            return _instance;
        }

        
        

        public DataTable Chargement(string nomTable)
        {
            innitialiseConnection();
            con.Open();
            cmd = new SqlCommand("SELECT * FROM " + nomTable + "", con);
            dt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dt.Fill(ds);
            con.Close();
            return ds.Tables[0];
        }
        public int GetIdByName(string nomTable, string nomChamp, string nom)
        {

            innitialiseConnection();
            int id = -1;
            try
            {
                con.Open();
                string query = "SELECT Id FROM " + nomTable + " WHERE " + nomChamp + " = @nom";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nom", nom);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    id = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                System.Windows.Forms.MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return id;
        }
        public void Supprimer(string nomTable,string chamId,string valeur)
        {
            innitialiseConnection();
            con.Open();
            cmd = new SqlCommand("DELETE FROM "+nomTable+" WHERE "+chamId+"=@id", con);
            cmd.Parameters.AddWithValue("@id", valeur);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void chargeCombo(System.Windows.Forms.ComboBox cmb, string nomChamp, string nomTable)
        {
            innitialiseConnection();
            if (!con.State.ToString().Trim().ToLower().Equals("open")) con.Open();
            using (IDbCommand cmd = con.CreateCommand())
            {
                //cmd.CommandText = @"select distinct " + nomChamp + " from " + nomTable + "";
                cmd.CommandText = @"select distinct " + nomChamp + " from " + nomTable +"";

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    string de = rd[nomChamp].ToString();
                    cmb.Items.Add(de);
                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
        }
        public void ChargeCombobox(System.Windows.Forms.ComboBox cmb, string displayMember, string valueMember, string nomTable)
        {
            string connectionString = "server=EL;database=labo_db;uid=sa;pwd=dddd";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT " + valueMember + ", " + displayMember + " FROM " + nomTable, con))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(rd);

                        cmb.DisplayMember = displayMember;
                        cmb.ValueMember = valueMember;
                        cmb.DataSource = dt;
                    }
                }
            }
        }


        public void EnregistrerClient(tClient cl)
        {
            //innitialiseConnection();
            con = new SqlConnection("server=EL;database=labo_db;uid=sa;pwd=dddd");
            con.Open();
            cmd = new SqlCommand("INSERT INTO tClient values (@noms,@adresse,@contact)", con);
            cmd.Parameters.AddWithValue("@noms", cl.Noms);
            cmd.Parameters.AddWithValue("@adresse", cl.Adresse);
            cmd.Parameters.AddWithValue("@contact", cl.Contact);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ModifierClient(tClient cl)
        {
            con = new SqlConnection("server=EL;database=labo_db;uid=sa;pwd=dddd");
            con.Open();
            cmd = new SqlCommand("UPDATE tClient SET noms=@noms,adresse=@adresse,contact=@contact WHERE id=@id ", con);
            cmd.Parameters.AddWithValue("@id", cl.Id);
            cmd.Parameters.AddWithValue("@noms", cl.Noms);
            cmd.Parameters.AddWithValue("@adresse", cl.Adresse);
            cmd.Parameters.AddWithValue("@contact", cl.Contact);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void EnregistrerCategorie(tCategorie cat)
        {
            con = new SqlConnection("server=EL;database=labo_db;uid=sa;pwd=dddd");
            con.Open();
            cmd = new SqlCommand("INSERT INTO tCategorie values (@designation)", con);
            cmd.Parameters.AddWithValue("@designation", cat.Designation);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ModifierCategorie(tCategorie cat)
        {
            con = new SqlConnection("server=EL;database=labo_db;uid=sa;pwd=dddd");
            con.Open();
            cmd = new SqlCommand("UPDATE tCategorie SET designation=@designation WHERE id=@id ", con);
            cmd.Parameters.AddWithValue("@id", cat.Id);
            cmd.Parameters.AddWithValue("@designation", cat.Designation);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void EnregistrerProduit(tProduit prod)
        {
            con = new SqlConnection("server=EL;database=labo_db;uid=sa;pwd=dddd");
            con.Open();
            cmd = new SqlCommand("INSERT INTO tProduit values (@nom_produit, @pu, @refCatgorie)", con);
            cmd.Parameters.AddWithValue("@nom_produit", prod.Nom_produit);
            cmd.Parameters.AddWithValue("@pu", prod.Pu);
            cmd.Parameters.AddWithValue("@refCatgorie", prod.Categorie);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ModifierProduit(tProduit prod)
        {
            con = new SqlConnection("server=EL;database=labo_db;uid=sa;pwd=dddd");
            con.Open();
            cmd = new SqlCommand("UPDATE tProduit SET nom_produit=@nom_produit, pu=@pu, refCatgorie=@refCatgorie WHERE id=@id ", con);
            cmd.Parameters.AddWithValue("@id", prod.Id);
            cmd.Parameters.AddWithValue("@nom_produit", prod.Nom_produit);
            cmd.Parameters.AddWithValue("@pu", prod.Pu);
            cmd.Parameters.AddWithValue("@refCatgorie", prod.Categorie);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void EnregistrerVente(tVente vente)
        {
            con = new SqlConnection("server=EL;database=labo_db;uid=sa;pwd=dddd");
            con.Open();
            cmd = new SqlCommand("INSERT INTO tVente values (@date_vente, @refClient)", con);
            cmd.Parameters.AddWithValue("@date_vente", vente.Date_vente);
            cmd.Parameters.AddWithValue("@refClient", vente.Client);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ModifierVente(tVente vente)
        {
            con = new SqlConnection("server=EL;database=labo_db;uid=sa;pwd=dddd");
            con.Open();
            cmd = new SqlCommand("UPDATE tVente SET date_vente=@date_vente, refClient=@refClient WHERE id=@id ", con);
            cmd.Parameters.AddWithValue("@id", vente.Id);
            cmd.Parameters.AddWithValue("@date_vente", vente.Date_vente);
            cmd.Parameters.AddWithValue("@refClient", vente.Client);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void EnregistrerDetailVente(tDetailVente dVente)
        {
            con = new SqlConnection("server=EL;database=labo_db;uid=sa;pwd=dddd");
            con.Open();
            cmd = new SqlCommand("INSERT INTO tDetailVente values (@refProduit, @qte, @pu_vente)", con);
            cmd.Parameters.AddWithValue("@refProduit", dVente.RefProduit);
            cmd.Parameters.AddWithValue("@qte", dVente.Qte);
            cmd.Parameters.AddWithValue("@pu_vente", dVente.Pu_vente);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ModifierDetailVente(tDetailVente dVente)
        {
            con = new SqlConnection("server=EL;database=labo_db;uid=sa;pwd=dddd");
            con.Open();
            cmd = new SqlCommand("UPDATE tDetailVente SET refProduit=@refProduit, qte=@qte, pu_vente=@pu_vente WHERE id=@id ", con);
            cmd.Parameters.AddWithValue("@id", dVente.Id);
            cmd.Parameters.AddWithValue("@refProduit", dVente.RefProduit);
            cmd.Parameters.AddWithValue("@qte", dVente.Qte);
            cmd.Parameters.AddWithValue("@pu_vente", dVente.Pu_vente);
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
