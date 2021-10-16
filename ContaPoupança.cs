using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBank
{
    public class ContaPoupança : Conta
    {
        public ContaPoupança(Cliente cliente, int agencia, int conta){
            this.setTitular(titular);
            this.setAgencia(agencia);
            this.setConta(conta);
        }
    }
}