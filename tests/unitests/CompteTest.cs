using NUnit.Framework;

namespace banque_simple
{
    [TestFixture]
    public class CompteTest 
    {
        // Référence de l'objet à tester
        private Compte compte;

        [SetUp]
        public void setUp() 
        {
            compte = new Compte(456236, 1000.00, "rdupont@gmail.com");
        }

        [Test]
        public void testGetNumero() 
        {
            // On appelle la méthode à tester (la propriété...)
            long numero = compte.Numero;
            // On compare la valeur obtenue avec la valeur attendue
            Assert.AreEqual(456236, numero);

            // Assert.IsTrue(456236 == numero);
        }

        [Test]
        public void testSetNumero()
        {
            compte.Numero = 968563;
            // Pas le choix d'appeler le getNumero....
            long numero = compte.Numero;
            Assert.AreEqual(968563, numero);
        }

        [Test]
        public void testGetSolde() 
        {
            Assert.AreEqual(1000.00, compte.Solde);
        }

        [Test]
        public void testSetSolde()
        {
            compte.Solde = 2000.00;
            Assert.AreEqual(2000.00, compte.Solde);
        }

        [Test]
        public void testGetReferenceClient() 
        {
            Assert.AreEqual("rdupont@gmail.com", compte.ReferenceClient);
        }

        [Test]
        public void testSetReferenceClient()
        {
            compte.ReferenceClient = "smartin@yahoo.fr";
            Assert.AreEqual("smartin@yahoo.fr", compte.ReferenceClient);
        }

        [Test]
        public void testCompte() 
        {
            // Test du constructeur sans paramètres...
            Compte compte = new Compte();

            Assert.NotNull(compte);
            // ...
        }

        [Test]
        public void testCompteParams()
        {
            Compte compte = new Compte(965423, 255.23, "sduport@outlook.fr");

            Assert.NotNull(compte);		
            Assert.AreEqual(965423, compte.Numero);
            Assert.AreEqual(255.23, compte.Solde, 0);
            Assert.AreEqual("sduport@outlook.fr", compte.ReferenceClient);
        }
    }

}
