using System;


    class AlunoClass{

        public string _nome;
        public int _idade{
            get{
                return _idade;

            }set{
               if(_idade>0){
                   _idade =  1;
               }
            }
        }       


        public void cadastro(string nome, int idade){
            _nome = nome;
            _idade = idade;

        }
        public void Ler(){
            Console.WriteLine("Nome: " +this._nome + "\nIdade: " +this._idade );
        }
    
}
