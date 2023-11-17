using System;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Extension;

namespace PEGASUS.IcarusWings
{
    public static class CreateCertificate
    {
        public static X509Certificate2 CreateCertificateAuthority(string caName, int keyStrength)
        {
            var random = new SecureRandom();
            var keyPairGen = new RsaKeyPairGenerator();
            keyPairGen.Init(new KeyGenerationParameters(random, keyStrength));
            var keypair = keyPairGen.GenerateKeyPair();

            var certificateGenerator = new X509V3CertificateGenerator();

            var issuer = new X509Name(@"CN=" + caName + ",OU=PEGASUS,O=PEGASUS By PEGASUSSoft,L=SH,C=CN");
            var certName = new X509Name(@"CN=PEGASUS");
            var SN = BigInteger.ProbablePrime(160, new SecureRandom());

            certificateGenerator.SetSerialNumber(SN);
            certificateGenerator.SetSubjectDN(certName);
            certificateGenerator.SetIssuerDN(issuer);
            certificateGenerator.SetNotAfter(DateTime.UtcNow.Subtract(new TimeSpan(-3650, 0, 0, 0)));
            certificateGenerator.SetNotBefore(DateTime.UtcNow.Subtract(new TimeSpan(285, 0, 0, 0)));
            certificateGenerator.SetPublicKey(keypair.Public);
            certificateGenerator.AddExtension(X509Extensions.SubjectKeyIdentifier, false,
                new SubjectKeyIdentifierStructure(keypair.Public));
            certificateGenerator.AddExtension(X509Extensions.BasicConstraints, true, new BasicConstraints(true));

            ISignatureFactory signatureFactory = new Asn1SignatureFactory("SHA512WITHRSA", keypair.Private, random);

            var certificate = certificateGenerator.Generate(signatureFactory);

            var certificate2 = new X509Certificate2(DotNetUtilities.ToX509Certificate(certificate));
            certificate2.PrivateKey = DotNetUtilities.ToRSA(keypair.Private as RsaPrivateCrtKeyParameters);

            return certificate2;
        }
    }
}