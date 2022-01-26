using Xunit;

namespace Metaverso
{

    public class SistemaTest
    {

        [Fact]
        
        public void ComprobacionnumeroTest(){
            var sis = new Sistema();
            var num = 5;
            var falso = $"MAL  {num}!";
            var result = sis.Comprobacionnumero(num);
        }

        [Fact]
        public void ComprobacionarrayTest(){
            var sis = new Sistema();
            int[] lista = {1,5,4,8,30,15};
            var falso = $"MAL  {lista}!";
            var result = sis.Comprobacionarray(lista);
        }
    }
}
