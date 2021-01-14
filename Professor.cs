namespace Teste1
{
    public class Professor
    {
        public string _nome{
            get{
                return _nome;
                }set{
                    _nome = this._nome;
                    }
            }
        public int _idade;

        public int _id;

         public void CadastroProfessor(string nome, int idade, int id){
             _nome = nome;
             _idade = idade;
             _id = id;
        
        }
    }

}