namespace CSharpNewVersion
{
    internal class EnhancementInterpolatedVerbatimStrings
    {
        public void EnhancementInterpolatedVerbatimStringsTest()
        {
            var price = 10;

            var message = "O valor do item é de " + price.ToString() + "!" +
                " Boas compras!";

            var message2 = $"O valor do item é de {price.ToString()}! " +
                " Boas compras!";

            var message3 = $@"O valor do item é de {price.ToString()}!
                  Boas compras!";

            //var message4 = @$"O valor do item é de {price.ToString()}!
            //      Boas compras!";
        }
    }
}