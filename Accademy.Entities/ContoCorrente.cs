using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Entities
{
    public class ContoCorrente
    {
        private String numeroConto;
        private double saldo;
        private Cliente owner;
        public ContoCorrente(Cliente owner)
        {
            this.owner = owner;
        }
        public ContoCorrente(Cliente owner, string numeroConto)
        {
            this.numeroConto = numeroConto;
            saldo = 0;
            this.owner = owner;
        }

        public Cliente GetOwner()
        {
            return owner;
        }
        public string GetNumeroConto()
        {
            return numeroConto;
        }
        public double GetSaldo()
        {
            return saldo;
        }
        public OperationResult Deposita(double cifra)
        {
            saldo += cifra;
            return OperationResult.Operazione_OK;
        }
        public OperationResult Preleva(double cifra)
        {
            OperationResult result = OperationResult.FondiInsufficienti;

            if (saldo >= cifra)
            {
                saldo -= cifra;
                result = OperationResult.Operazione_OK;
            }
            return result;
        }
        public OperationResult Bonifico(double cifra, ContoCorrente beneficiario)
        {
            //da implementare
            return OperationResult.Operazione_OK;
        }
    }
}
