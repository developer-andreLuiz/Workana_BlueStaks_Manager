using BotAbrirSoftware.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotAbrirSoftware.DAO
{
    internal class EmuladorDAO
    {
        public static List<Emulador> GetAll()
        {
            List<Emulador> list = new List<Emulador>();
            try
            {
                using (var database = new DBContextDAO())
                {
                    var itens = database.Emuladors.AsNoTracking().AsQueryable().OrderBy(x => x.Id);
                    list.AddRange(itens.ToList());
                }
            }
            catch { }

            return list;
        }
        public static Emulador Insert(Emulador obj)
        {
            try
            {
                using (var database = new DBContextDAO())
                {
                    database.Add(obj);
                    database.SaveChanges();
                }
                return obj;
            }
            catch (Exception ex)
            {
                string msg = $"Registro não Inserido.{Environment.NewLine}Mensagem de Erro: {ex.Message}";
                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
                return new Emulador();
            }

        }
        public static Emulador Update(Emulador obj)
        {
            try
            {
                using (var database = new DBContextDAO())
                {
                    database.Update(obj);
                    database.SaveChanges();
                }
                return obj;
            }
            catch (Exception ex)
            {
                string msg = $"Registro não Atualizado.{Environment.NewLine}Mensagem de Erro: {ex.Message}";
                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Emulador();
            }

        }
        public static bool Delete(Emulador obj)
        {
            int value = 0;
            using (var database = new DBContextDAO())
            {
                database.Remove(obj);
                value = database.SaveChanges();
            }
            if (value == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Truncate()
        {
            int value = 0;
            using (var database = new DBContextDAO())
            {
                database.Emuladors.RemoveRange(GetAll());
                value = database.SaveChanges();
            }
            if (value == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
