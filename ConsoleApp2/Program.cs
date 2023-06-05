using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s2 = "ThggZyoFZEDebt5jSS3dQsnkgLRw6LNq7n2b2DpBuLkCc1M2TvTtKc7F0ZqhgmdjeSP8ZIuS4C5tAuiZ/687nj2xbHXX5LqoHB+Hz267/f73jS9DFRluz1JRBDVYQMVvo2qWyqudBqc2avRIyJg6YzAUiDyFrNkExXrHgbvjg3oaaC4P2vsXWRXNUxAl+xaETm1g1bCZVozqW5vlLMRsfd3itW+nBNejQWRrXhBiJtLRGLOuBZGTVGLbFieR/veDsDaMIS4vYloS7koN+gJ1koDzfQtGIm2x6Q3auaPFZ99bUH8AIV5erZYvRmt7+l7jyQWRH2y02gLW2y/+4JoQyA==";
            string text12 = "3ki45T6C4lt12J5MbKfrADBCZcE8OTefdngc9IDKg+lzCGYLuxJFDt16awhJFnA23sX+kQ4/eZQ5pNAYjc+ZJ0+pWwvQR4h8GJ3eWvecdFs7KSWwNmFXZCSN+sbrxwEjzzns1kIHuLNf5r+Zaggns+8rqXR19RSJBOcuFqVipIHv56lF53Hc+hx+y9URIaadO1W8dkTqgwExyfjnbDOaCBEH0CqUL1YIICS/wIUTEKhM0ZlwEcIcHl8XTHLVx96DMX4bbVajj78L4KzevQc442DX28KGDJTveEB1pSKWsr0d4FTx7wKS36RBnWv5lwsRErtTZb5ciVIG1iIJrp87VQ==";
            byte[] zUeFdDdmzVWDmTkhw4w = Convert.FromBase64String("AQAB");//公钥
            byte[] array28 = Convert.FromBase64String(s2);
            byte[] array30 = Convert.FromBase64String(text12);//加密数据
            JadRzF0VXk zrz0fDFXe1TTo_JadRzF0VXk = new JadRzF0VXk(array30, zUeFdDdmzVWDmTkhw4w);
            byte[] array32 = zrz0fDFXe1TTo_JadRzF0VXk.zHnajSQA(array28);//解密
            byte[] array33 = RsLAf.zfcV5mGdQJrLv(array32, zrz0fDFXe1TTo_JadRzF0VXk.znrH2tyKojoR2().z6WrXYK4() >> 3);//加密，第二个为密钥
        }
        public class JadRzF0VXk
        {
            /// <summary>
            /// 公钥
            /// </summary>
            public AXmaMClass ztZMWUIw;
            /// <summary>
            /// 公钥指数
            /// </summary>
            public AXmaMClass zP84Y9SI;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="zk0bTzYNdLH4RUhympA">公钥</param>
            /// <param name="zUeFdDdmzVWDmTkhw4w">公钥指数</param>
            public JadRzF0VXk(byte[] zk0bTzYNdLH4RUhympA, byte[] zUeFdDdmzVWDmTkhw4w)
            {
                this.ztZMWUIw = new AXmaMClass(zk0bTzYNdLH4RUhympA);
                this.zP84Y9SI = new AXmaMClass(zUeFdDdmzVWDmTkhw4w);
            }
            /// <summary>
            /// 利用传入的公钥和公钥指数对 byte 数组进行 RSA 加密，并返回加密后的 byte 数组结果
            /// </summary>
            /// <param name="zffNI1RT4Ochv"></param>
            /// <returns></returns>
            public byte[] zHnajSQA(byte[] zffNI1RT4Ochv)
            {
                AXmaMClass ztT1t6JDlZEKtbzIzCqAXmaM = new AXmaMClass(zffNI1RT4Ochv);
                AXmaMClass ztT1t6JDlZEKtbzIzCqAXmaM2 = ztT1t6JDlZEKtbzIzCqAXmaM.zJ_ZjYevNJzfV(this.zP84Y9SI, this.ztZMWUIw);
                byte[] result = ztT1t6JDlZEKtbzIzCqAXmaM2.zY40YPzc();

                return result;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <returns>公钥</returns>
            public AXmaMClass znrH2tyKojoR2()
            {
                return this.ztZMWUIw;
            }
        }
        public sealed class AXmaMClass
        {
            private uint zZW7BdZ0 = 1U;
            private uint[] z6Ujs0yU;
            public byte[] zY40YPzc()
            {
                bool flag = this == 0U;
                byte[] result;
                if (flag)
                {
                    result = new byte[1];
                }
                else
                {
                    int num = this.z6WrXYK4();
                    int num2 = num >> 3;
                    bool flag2 = (num & 7) != 0;
                    if (flag2)
                    {
                        num2++;
                    }
                    byte[] array = new byte[num2];
                    int num3 = num2 & 3;
                    bool flag3 = num3 == 0;
                    if (flag3)
                    {
                        num3 = 4;
                    }
                    int num4 = 0;
                    for (int i = (int)(this.zZW7BdZ0 - 1U); i >= 0; i--)
                    {
                        uint num5 = this.z6Ujs0yU[i];
                        for (int j = num3 - 1; j >= 0; j--)
                        {
                            array[num4 + j] = (byte)num5;
                            num5 >>= 8;
                        }
                        num4 += num3;
                        num3 = 4;
                    }
                    result = array;
                }
                return result;
            }
            public AXmaMClass(byte[] zR1aFGps)
            {
                this.zZW7BdZ0 = (uint)zR1aFGps.Length >> 2;
                int num = zR1aFGps.Length & 3;
                bool flag = num != 0;
                if (flag)
                {
                    this.zZW7BdZ0 += 1U;
                }
                this.z6Ujs0yU = new uint[this.zZW7BdZ0];
                int i = zR1aFGps.Length - 1;
                int num2 = 0;
                while (i >= 3)
                {
                    this.z6Ujs0yU[num2] = (uint)((int)zR1aFGps[i - 3] << 24 | (int)zR1aFGps[i - 2] << 16 | (int)zR1aFGps[i - 1] << 8 | (int)zR1aFGps[i]);
                    i -= 4;
                    num2++;
                }
                switch (num)
                {
                    case 1:
                        this.z6Ujs0yU[(int)(this.zZW7BdZ0 - 1U)] = (uint)zR1aFGps[0];
                        break;
                    case 2:
                        this.z6Ujs0yU[(int)(this.zZW7BdZ0 - 1U)] = (uint)((int)zR1aFGps[0] << 8 | (int)zR1aFGps[1]);
                        break;
                    case 3:
                        this.z6Ujs0yU[(int)(this.zZW7BdZ0 - 1U)] = (uint)((int)zR1aFGps[0] << 16 | (int)zR1aFGps[1] << 8 | (int)zR1aFGps[2]);
                        break;
                }
                this.zPx1f1l8();
            }
            private void zPx1f1l8()
            {
                while (this.zZW7BdZ0 > 0U && this.z6Ujs0yU[(int)(this.zZW7BdZ0 - 1U)] == 0U)
                {
                    this.zZW7BdZ0 -= 1U;
                }
                bool flag = this.zZW7BdZ0 == 0U;
                if (flag)
                {
                    this.zZW7BdZ0 += 1U;
                }
            }
            public AXmaMClass zJ_ZjYevNJzfV(AXmaMClass zAagvuio, AXmaMClass zAb8URrE)
            {

                z4l0LYBiH79q6 z4l0LYBiH79q = new z4l0LYBiH79q6(zAb8URrE);
                return z4l0LYBiH79q.zYaJUq4I(this, zAagvuio);
            }
            public sealed class z4l0LYBiH79q6
            {
                private AXmaMClass zhy2xauE;
                private AXmaMClass z9r71eDU;
                public z4l0LYBiH79q6(AXmaMClass zTl56HPOhBrmh)
                {
                    this.zhy2xauE = zTl56HPOhBrmh;
                    uint num = this.zhy2xauE.zZW7BdZ0 << 1;
                    this.z9r71eDU = new AXmaMClass((AXmaMClass.zgF6UnO8)1, num + 1U);
                    this.z9r71eDU.z6Ujs0yU[(int)num] = 1U;
                    this.z9r71eDU /= this.zhy2xauE;
                }
                public AXmaMClass zYaJUq4I(AXmaMClass zsXgJLo, AXmaMClass zAagvuio)
                {
                    bool flag = (this.zhy2xauE.z6Ujs0yU[0] & 1U) == 1U;
                    AXmaMClass result;
                    if (flag)
                    {
                        result = this.zfXpSKDCp4sY(zsXgJLo, zAagvuio);
                    }
                    else
                    {
                        result = this.zUS3IxQcvycb3(zsXgJLo, zAagvuio);
                    }
                    return result;
                }
                public void zMLUuCJlpE3JekIR0A(AXmaMClass zfRBKONA)
                {
                    AXmaMClass ztT1t6JDlZEKtbzIzCqAXmaM = this.zhy2xauE;
                    uint zZW7BdZ0 = ztT1t6JDlZEKtbzIzCqAXmaM.zZW7BdZ0;
                    uint num = zZW7BdZ0 + 1U;
                    uint num2 = zZW7BdZ0 - 1U;
                    bool flag = zfRBKONA.zZW7BdZ0 < zZW7BdZ0;
                    if (!flag)
                    {
                        bool flag2 = (long)zfRBKONA.z6Ujs0yU.Length < (long)((ulong)zfRBKONA.zZW7BdZ0);
                        if (flag2)
                        {
                            throw new IndexOutOfRangeException(FAc8zIk.z2uo70I4(-1302901995));
                        }
                        AXmaMClass ztT1t6JDlZEKtbzIzCqAXmaM2 = new AXmaMClass((AXmaMClass.zgF6UnO8)1, zfRBKONA.zZW7BdZ0 - num2 + this.z9r71eDU.zZW7BdZ0);
                        AXmaMClass.zCVEM1E8.zFZJkLuDvRCeB(zfRBKONA.z6Ujs0yU, num2, zfRBKONA.zZW7BdZ0 - num2, this.z9r71eDU.z6Ujs0yU, 0U, this.z9r71eDU.zZW7BdZ0, ztT1t6JDlZEKtbzIzCqAXmaM2.z6Ujs0yU, 0U);
                        uint zZW7BdZ02 = (zfRBKONA.zZW7BdZ0 > num) ? num : zfRBKONA.zZW7BdZ0;
                        zfRBKONA.zZW7BdZ0 = zZW7BdZ02;
                        zfRBKONA.zPx1f1l8();
                        AXmaMClass ztT1t6JDlZEKtbzIzCqAXmaM3 = new AXmaMClass((AXmaMClass.zgF6UnO8)1, num);
                        AXmaMClass.zCVEM1E8.zEtMEfl5s02X6TltxII1FZYo(ztT1t6JDlZEKtbzIzCqAXmaM2.z6Ujs0yU, (int)num, (int)(ztT1t6JDlZEKtbzIzCqAXmaM2.zZW7BdZ0 - num), ztT1t6JDlZEKtbzIzCqAXmaM.z6Ujs0yU, 0, (int)ztT1t6JDlZEKtbzIzCqAXmaM.zZW7BdZ0, ztT1t6JDlZEKtbzIzCqAXmaM3.z6Ujs0yU, 0, (int)num);
                        ztT1t6JDlZEKtbzIzCqAXmaM3.zPx1f1l8();
                        bool flag3 = ztT1t6JDlZEKtbzIzCqAXmaM3 <= zfRBKONA;
                        if (flag3)
                        {
                            AXmaMClass.zCVEM1E8.z_5OxBSSOlahJ(zfRBKONA, ztT1t6JDlZEKtbzIzCqAXmaM3);
                        }
                        else
                        {
                            AXmaMClass ztT1t6JDlZEKtbzIzCqAXmaM4 = new AXmaMClass((AXmaMClass.zgF6UnO8)1, num + 1U);
                            ztT1t6JDlZEKtbzIzCqAXmaM4.z6Ujs0yU[(int)num] = 1U;
                            AXmaMClass.zCVEM1E8.z_5OxBSSOlahJ(ztT1t6JDlZEKtbzIzCqAXmaM4, ztT1t6JDlZEKtbzIzCqAXmaM3);
                            AXmaMClass.zCVEM1E8.zDb8s4guMxH8Y(zfRBKONA, ztT1t6JDlZEKtbzIzCqAXmaM4);
                        }
                        while (zfRBKONA >= ztT1t6JDlZEKtbzIzCqAXmaM)
                        {
                            AXmaMClass.zCVEM1E8.z_5OxBSSOlahJ(zfRBKONA, ztT1t6JDlZEKtbzIzCqAXmaM);
                        }
                    }
                }
                public AXmaMClass zUS3IxQcvycb3(AXmaMClass zsXgJLo, AXmaMClass zAagvuio)
                {
                    AXmaMClass ztT1t6JDlZEKtbzIzCqAXmaM = new AXmaMClass(1, this.zhy2xauE.zZW7BdZ0 << 1);
                    AXmaMClass ztT1t6JDlZEKtbzIzCqAXmaM2 = new AXmaMClass(zsXgJLo % this.zhy2xauE, this.zhy2xauE.zZW7BdZ0 << 1);
                    uint num = (uint)zAagvuio.z6WrXYK4();
                    uint[] array = new uint[this.zhy2xauE.zZW7BdZ0 << 1];
                    for (uint num2 = 0U; num2 < num; num2 += 1U)
                    {
                        bool flag = zAagvuio.z1FOkbgM(num2);
                        if (flag)
                        {
                            Array.Clear(array, 0, array.Length);
                            AXmaMClass.zCVEM1E8.zFZJkLuDvRCeB(ztT1t6JDlZEKtbzIzCqAXmaM.z6Ujs0yU, 0U, ztT1t6JDlZEKtbzIzCqAXmaM.zZW7BdZ0, ztT1t6JDlZEKtbzIzCqAXmaM2.z6Ujs0yU, 0U, ztT1t6JDlZEKtbzIzCqAXmaM2.zZW7BdZ0, array, 0U);
                            ztT1t6JDlZEKtbzIzCqAXmaM.zZW7BdZ0 += ztT1t6JDlZEKtbzIzCqAXmaM2.zZW7BdZ0;
                            uint[] z6Ujs0yU = array;
                            array = ztT1t6JDlZEKtbzIzCqAXmaM.z6Ujs0yU;
                            ztT1t6JDlZEKtbzIzCqAXmaM.z6Ujs0yU = z6Ujs0yU;
                            this.zMLUuCJlpE3JekIR0A(ztT1t6JDlZEKtbzIzCqAXmaM);
                        }
                        AXmaMClass.zCVEM1E8.zTEl5JihyJsNo(ztT1t6JDlZEKtbzIzCqAXmaM2, ref array);
                        this.zMLUuCJlpE3JekIR0A(ztT1t6JDlZEKtbzIzCqAXmaM2);
                        bool flag2 = ztT1t6JDlZEKtbzIzCqAXmaM2 == 1U;
                        if (flag2)
                        {
                            return ztT1t6JDlZEKtbzIzCqAXmaM;
                        }
                    }
                    return ztT1t6JDlZEKtbzIzCqAXmaM;
                }
                private AXmaMClass zfXpSKDCp4sY(AXmaMClass zsXgJLo, AXmaMClass zAagvuio)
                {
                    AXmaMClass ztT1t6JDlZEKtbzIzCqAXmaM = new AXmaMClass(AXmaMClass.z9p2YuZlCRaS7fJbcGA.zXgQaqhBb4aFJ(1, this.zhy2xauE), this.zhy2xauE.zZW7BdZ0 << 1);
                    AXmaMClass ztT1t6JDlZEKtbzIzCqAXmaM2 = new AXmaMClass(AXmaMClass.z9p2YuZlCRaS7fJbcGA.zXgQaqhBb4aFJ(zsXgJLo, this.zhy2xauE), this.zhy2xauE.zZW7BdZ0 << 1);
                    uint zfhCrwhk = AXmaMClass.z9p2YuZlCRaS7fJbcGA.zFWWfeLo(this.zhy2xauE.z6Ujs0yU[0]);
                    uint num = (uint)zAagvuio.z6WrXYK4();
                    uint[] array = new uint[this.zhy2xauE.zZW7BdZ0 << 1];
                    for (uint num2 = 0U; num2 < num; num2 += 1U)
                    {
                        bool flag = zAagvuio.z1FOkbgM(num2);
                        if (flag)
                        {
                            Array.Clear(array, 0, array.Length);
                            AXmaMClass.zCVEM1E8.zFZJkLuDvRCeB(ztT1t6JDlZEKtbzIzCqAXmaM.z6Ujs0yU, 0U, ztT1t6JDlZEKtbzIzCqAXmaM.zZW7BdZ0, ztT1t6JDlZEKtbzIzCqAXmaM2.z6Ujs0yU, 0U, ztT1t6JDlZEKtbzIzCqAXmaM2.zZW7BdZ0, array, 0U);
                            ztT1t6JDlZEKtbzIzCqAXmaM.zZW7BdZ0 += ztT1t6JDlZEKtbzIzCqAXmaM2.zZW7BdZ0;
                            uint[] z6Ujs0yU = array;
                            array = ztT1t6JDlZEKtbzIzCqAXmaM.z6Ujs0yU;
                            ztT1t6JDlZEKtbzIzCqAXmaM.z6Ujs0yU = z6Ujs0yU;
                            AXmaMClass.z9p2YuZlCRaS7fJbcGA.zKLp_R5c(ztT1t6JDlZEKtbzIzCqAXmaM, this.zhy2xauE, zfhCrwhk);
                        }
                        AXmaMClass.zCVEM1E8.zTEl5JihyJsNo(ztT1t6JDlZEKtbzIzCqAXmaM2, ref array);
                        AXmaMClass.z9p2YuZlCRaS7fJbcGA.zKLp_R5c(ztT1t6JDlZEKtbzIzCqAXmaM2, this.zhy2xauE, zfhCrwhk);
                    }
                    AXmaMClass.z9p2YuZlCRaS7fJbcGA.zKLp_R5c(ztT1t6JDlZEKtbzIzCqAXmaM, this.zhy2xauE, zfhCrwhk);
                    return ztT1t6JDlZEKtbzIzCqAXmaM;
                }
            }
            public sealed class z9p2YuZlCRaS7fJbcGA
            {
                public static uint zFWWfeLo(uint zAb8URrE)
                {
                    uint num = zAb8URrE;
                    uint num2;
                    while ((num2 = zAb8URrE * num) != 1U)
                    {
                        num *= 2U - num2;
                    }
                    return (uint)(-(uint)((ulong)num));
                }
                public static AXmaMClass zXgQaqhBb4aFJ(AXmaMClass zAb8URrE, AXmaMClass zfzM10B4)
                {
                    zAb8URrE.zPx1f1l8();
                    zfzM10B4.zPx1f1l8();
                    zAb8URrE <<= (int)(zfzM10B4.zZW7BdZ0 * 32U);
                    zAb8URrE %= zfzM10B4;
                    return zAb8URrE;
                }
                public static AXmaMClass zKLp_R5c(AXmaMClass zAb8URrE, AXmaMClass zfzM10B4, uint zfhCrwhk)
                {
                    uint[] z6Ujs0yU = zAb8URrE.z6Ujs0yU;
                    uint[] z6Ujs0yU2 = zfzM10B4.z6Ujs0yU;
                    for (uint num = 0U; num < zfzM10B4.zZW7BdZ0; num += 1U)
                    {
                        uint num2 = z6Ujs0yU[0] * zfhCrwhk;
                        uint num3 = 0U;
                        uint num4 = 0U;
                        uint num5 = 0U;
                        ulong num6 = (ulong)num2 * (ulong)z6Ujs0yU2[(int)num3++] + (ulong)z6Ujs0yU[(int)num4++];
                        num6 >>= 32;
                        uint num7;
                        for (num7 = 1U; num7 < zfzM10B4.zZW7BdZ0; num7 += 1U)
                        {
                            num6 += (ulong)num2 * (ulong)z6Ujs0yU2[(int)num3++] + (ulong)z6Ujs0yU[(int)num4++];
                            z6Ujs0yU[(int)num5++] = (uint)num6;
                            num6 >>= 32;
                        }
                        while (num7 < zAb8URrE.zZW7BdZ0)
                        {
                            num6 += (ulong)z6Ujs0yU[(int)num4++];
                            z6Ujs0yU[(int)num5++] = (uint)num6;
                            num6 >>= 32;
                            bool flag = num6 == 0UL;
                            if (flag)
                            {
                                num7 += 1U;
                                break;
                            }
                            num7 += 1U;
                        }
                        while (num7 < zAb8URrE.zZW7BdZ0)
                        {
                            z6Ujs0yU[(int)num5++] = z6Ujs0yU[(int)num4++];
                            num7 += 1U;
                        }
                        z6Ujs0yU[(int)num5++] = (uint)num6;
                    }
                    while (zAb8URrE.zZW7BdZ0 > 1U && z6Ujs0yU[(int)(zAb8URrE.zZW7BdZ0 - 1U)] == 0U)
                    {
                        zAb8URrE.zZW7BdZ0 -= 1U;
                    }
                    bool flag2 = zAb8URrE >= zfzM10B4;
                    if (flag2)
                    {
                        AXmaMClass.zCVEM1E8.z_5OxBSSOlahJ(zAb8URrE, zfzM10B4);
                    }
                    return zAb8URrE;
                }
            }
            public static bool operator <=(AXmaMClass z9RjxOYo, AXmaMClass z8QaM2k8)
            {
                return AXmaMClass.zCVEM1E8.z1pvawiI(z9RjxOYo, z8QaM2k8) <= (AXmaMClass.zgF6UnO8)0;
            }
            public static bool operator >=(AXmaMClass z9RjxOYo, AXmaMClass z8QaM2k8)
            {
                return AXmaMClass.zCVEM1E8.z1pvawiI(z9RjxOYo, z8QaM2k8) >= (AXmaMClass.zgF6UnO8)0;
            }
            public static AXmaMClass operator <<(AXmaMClass z9RjxOYo, int zF1cjQXJ8n1D7)
            {
                return AXmaMClass.zCVEM1E8.zsHmjaX41Fwy(z9RjxOYo, zF1cjQXJ8n1D7);
            }
            public static AXmaMClass operator >>(AXmaMClass z9RjxOYo, int zF1cjQXJ8n1D7)
            {
                return AXmaMClass.zCVEM1E8.zeZUOeBtSYDxZ(z9RjxOYo, zF1cjQXJ8n1D7);
            }
            public static bool operator ==(AXmaMClass z9RjxOYo, uint z08fgjBM)
            {
                bool flag = z9RjxOYo.zZW7BdZ0 != 1U;
                if (flag)
                {
                    z9RjxOYo.zPx1f1l8();
                }
                return z9RjxOYo.zZW7BdZ0 == 1U && z9RjxOYo.z6Ujs0yU[0] == z08fgjBM;
            }
            public static bool operator !=(AXmaMClass z9RjxOYo, uint z08fgjBM)
            {
                bool flag = z9RjxOYo.zZW7BdZ0 != 1U;
                if (flag)
                {
                    z9RjxOYo.zPx1f1l8();
                }
                return z9RjxOYo.zZW7BdZ0 != 1U || z9RjxOYo.z6Ujs0yU[0] != z08fgjBM;
            }
            public bool z1FOkbgM(uint z_lj8WYmLJp_3)
            {
                uint num = z_lj8WYmLJp_3 >> 5;
                byte b = (byte)(z_lj8WYmLJp_3 & 31U);
                uint num2 = 1U << (int)b;
                return (this.z6Ujs0yU[(int)num] & num2) > 0U;
            }
            public int z6WrXYK4()
            {
                this.zPx1f1l8();
                uint num = this.z6Ujs0yU[(int)(this.zZW7BdZ0 - 1U)];
                uint num2 = 2147483648U;
                uint num3 = 32U;
                while (num3 > 0U && (num & num2) == 0U)
                {
                    num3 -= 1U;
                    num2 >>= 1;
                }
                return (int)(num3 + (this.zZW7BdZ0 - 1U << 5));
            }
            public static AXmaMClass operator %(AXmaMClass z9RjxOYo, AXmaMClass z8QaM2k8)
            {
                return AXmaMClass.zCVEM1E8.zga2vMhK71NoA(z9RjxOYo, z8QaM2k8)[1];
            }
            public AXmaMClass(AXmaMClass z6Mg5G3Y, uint ztYGiv4o)
            {
                this.z6Ujs0yU = new uint[ztYGiv4o];
                for (uint num = 0U; num < z6Mg5G3Y.zZW7BdZ0; num += 1U)
                {
                    this.z6Ujs0yU[(int)num] = z6Mg5G3Y.z6Ujs0yU[(int)num];
                }
                this.zZW7BdZ0 = z6Mg5G3Y.zZW7BdZ0;
            }
            public static AXmaMClass operator /(AXmaMClass z9RjxOYo, AXmaMClass z8QaM2k8)
            {
                return AXmaMClass.zCVEM1E8.zga2vMhK71NoA(z9RjxOYo, z8QaM2k8)[0];
            }
            public sealed class zCVEM1E8
            {
                public static void zDb8s4guMxH8Y(AXmaMClass z9RjxOYo, AXmaMClass z8QaM2k8)
                {
                    uint num = 0U;
                    bool flag = false;
                    bool flag2 = z9RjxOYo.zZW7BdZ0 < z8QaM2k8.zZW7BdZ0;
                    uint[] z6Ujs0yU;
                    uint zZW7BdZ0;
                    uint[] z6Ujs0yU2;
                    uint zZW7BdZ02;
                    if (flag2)
                    {
                        flag = true;
                        z6Ujs0yU = z8QaM2k8.z6Ujs0yU;
                        zZW7BdZ0 = z8QaM2k8.zZW7BdZ0;
                        z6Ujs0yU2 = z9RjxOYo.z6Ujs0yU;
                        zZW7BdZ02 = z9RjxOYo.zZW7BdZ0;
                    }
                    else
                    {
                        z6Ujs0yU = z9RjxOYo.z6Ujs0yU;
                        zZW7BdZ0 = z9RjxOYo.zZW7BdZ0;
                        z6Ujs0yU2 = z8QaM2k8.z6Ujs0yU;
                        zZW7BdZ02 = z8QaM2k8.zZW7BdZ0;
                    }
                    uint[] z6Ujs0yU3 = z9RjxOYo.z6Ujs0yU;
                    ulong num2 = 0UL;
                    do
                    {
                        num2 += (ulong)z6Ujs0yU[(int)num] + (ulong)z6Ujs0yU2[(int)num];
                        z6Ujs0yU3[(int)num] = (uint)num2;
                        num2 >>= 32;
                    }
                    while ((num += 1U) < zZW7BdZ02);
                    bool flag3 = num2 > 0UL;
                    bool flag4 = flag3;
                    if (flag4)
                    {
                        bool flag5 = num < zZW7BdZ0;
                        if (flag5)
                        {
                            do
                            {
                                flag3 = ((z6Ujs0yU3[(int)num] = z6Ujs0yU[(int)num] + 1U) == 0U);
                            }
                            while ((num += 1U) < zZW7BdZ0 && flag3);
                        }
                        bool flag6 = flag3;
                        if (flag6)
                        {
                            z6Ujs0yU3[(int)num] = 1U;
                            z9RjxOYo.zZW7BdZ0 = num + 1U;
                            return;
                        }
                    }
                    bool flag7 = flag && num < zZW7BdZ0 - 1U;
                    if (flag7)
                    {
                        do
                        {
                            z6Ujs0yU3[(int)num] = z6Ujs0yU[(int)num];
                        }
                        while ((num += 1U) < zZW7BdZ0);
                    }
                    z9RjxOYo.zZW7BdZ0 = zZW7BdZ0 + 1U;
                    z9RjxOYo.zPx1f1l8();
                }
                public static void zEtMEfl5s02X6TltxII1FZYo(uint[] zfRBKONA, int z6zvrKF8, int zvfzNuI, uint[] z6E4jpU4, int zdygT8W5w54Xm, int zO_onLrc, uint[] zuhFL5Zs, int zBrYwoUs, int zhy2xauE)
                {
                    uint num = (uint)z6zvrKF8;
                    uint num2 = num + (uint)zvfzNuI;
                    uint num3 = (uint)(zdygT8W5w54Xm + zO_onLrc);
                    uint num4 = (uint)zBrYwoUs;
                    uint num5 = num4 + (uint)zhy2xauE;
                    while (num < num2)
                    {
                        bool flag = zfRBKONA[(int)num] == 0U;
                        if (!flag)
                        {
                            ulong num6 = 0UL;
                            uint num7 = num4;
                            uint num8 = (uint)zdygT8W5w54Xm;
                            while (num8 < num3 && num7 < num5)
                            {
                                num6 += (ulong)zfRBKONA[(int)num] * (ulong)z6E4jpU4[(int)num8] + (ulong)zuhFL5Zs[(int)num7];
                                zuhFL5Zs[(int)num7] = (uint)num6;
                                num6 >>= 32;
                                num8 += 1U;
                                num7 += 1U;
                            }
                            bool flag2 = num6 != 0UL && num7 < num5;
                            if (flag2)
                            {
                                zuhFL5Zs[(int)num7] = (uint)num6;
                            }
                        }
                        num += 1U;
                        num4 += 1U;
                    }
                }
                public static void z_5OxBSSOlahJ(AXmaMClass zUOe5hws, AXmaMClass zVM2sbpQ)
                {
                    uint[] z6Ujs0yU = zUOe5hws.z6Ujs0yU;
                    uint[] z6Ujs0yU2 = zVM2sbpQ.z6Ujs0yU;
                    uint num = 0U;
                    uint num2 = 0U;
                    do
                    {
                        uint num3 = z6Ujs0yU2[(int)num];
                        bool flag = (num3 += num2) < num2 || (z6Ujs0yU[(int)num] -= num3) > ~num3;
                        if (flag)
                        {
                            num2 = 1U;
                        }
                        else
                        {
                            num2 = 0U;
                        }
                    }
                    while ((num += 1U) < zVM2sbpQ.zZW7BdZ0);
                    bool flag2 = num == zUOe5hws.zZW7BdZ0;
                    if (flag2)
                    {
                        while (zUOe5hws.zZW7BdZ0 > 0U && zUOe5hws.z6Ujs0yU[(int)(zUOe5hws.zZW7BdZ0 - 1U)] == 0U)
                        {
                            zUOe5hws.zZW7BdZ0 -= 1U;
                        }
                        bool flag3 = zUOe5hws.zZW7BdZ0 == 0U;
                        if (flag3)
                        {
                            zUOe5hws.zZW7BdZ0 += 1U;
                        }
                    }
                    else
                    {
                        bool flag4 = num2 == 1U;
                        if (flag4)
                        {
                            do
                            {
                                z6Ujs0yU[(int)num] -= 1U;
                            }
                            while (z6Ujs0yU[(int)num++] == 0U && num < zUOe5hws.zZW7BdZ0);
                        }
                        while (zUOe5hws.zZW7BdZ0 > 0U && zUOe5hws.z6Ujs0yU[(int)(zUOe5hws.zZW7BdZ0 - 1U)] == 0U)
                        {
                            zUOe5hws.zZW7BdZ0 -= 1U;
                        }
                        bool flag5 = zUOe5hws.zZW7BdZ0 == 0U;
                        if (flag5)
                        {
                            zUOe5hws.zZW7BdZ0 += 1U;
                        }
                    }
                }
                public static AXmaMClass zeZUOeBtSYDxZ(AXmaMClass z6Mg5G3Y, int zAb8URrE)
                {
                    bool flag = zAb8URrE == 0;
                    AXmaMClass result;
                    if (flag)
                    {
                        result = new AXmaMClass(z6Mg5G3Y);
                    }
                    else
                    {
                        int num = zAb8URrE >> 5;
                        int num2 = zAb8URrE & 31;
                        AXmaMClass ztT1t6JDlZEKtbzIzCqAXmaM = new AXmaMClass((AXmaMClass.zgF6UnO8)1, z6Mg5G3Y.zZW7BdZ0 - (uint)num + 1U);
                        uint num3 = (uint)(ztT1t6JDlZEKtbzIzCqAXmaM.z6Ujs0yU.Length - 1);
                        bool flag2 = num2 != 0;
                        if (flag2)
                        {
                            uint num4 = 0U;
                            while (num3-- > 0U)
                            {
                                uint num5 = z6Mg5G3Y.z6Ujs0yU[(int)(checked((IntPtr)(unchecked((ulong)num3 + (ulong)((long)num)))))];
                                ztT1t6JDlZEKtbzIzCqAXmaM.z6Ujs0yU[(int)num3] = (num5 >> zAb8URrE | num4);
                                num4 = num5 << 32 - zAb8URrE;
                            }
                        }
                        else
                        {
                            while (num3-- > 0U)
                            {
                                ztT1t6JDlZEKtbzIzCqAXmaM.z6Ujs0yU[(int)num3] = z6Mg5G3Y.z6Ujs0yU[(int)(checked((IntPtr)(unchecked((ulong)num3 + (ulong)((long)num)))))];
                            }
                        }
                        ztT1t6JDlZEKtbzIzCqAXmaM.zPx1f1l8();
                        result = ztT1t6JDlZEKtbzIzCqAXmaM;
                    }
                    return result;
                }
                public static AXmaMClass zsHmjaX41Fwy(AXmaMClass z6Mg5G3Y, int zAb8URrE)
                {
                    bool flag = zAb8URrE == 0;
                    AXmaMClass result;
                    if (flag)
                    {
                        result = new AXmaMClass(z6Mg5G3Y, z6Mg5G3Y.zZW7BdZ0 + 1U);
                    }
                    else
                    {
                        int num = zAb8URrE >> 5;
                        zAb8URrE &= 31;
                        AXmaMClass ztT1t6JDlZEKtbzIzCqAXmaM = new AXmaMClass((AXmaMClass.zgF6UnO8)1, z6Mg5G3Y.zZW7BdZ0 + 1U + (uint)num);
                        uint num2 = 0U;
                        uint zZW7BdZ0 = z6Mg5G3Y.zZW7BdZ0;
                        bool flag2 = zAb8URrE != 0;
                        if (flag2)
                        {
                            uint num3 = 0U;
                            while (num2 < zZW7BdZ0)
                            {
                                uint num4 = z6Mg5G3Y.z6Ujs0yU[(int)num2];
                                ztT1t6JDlZEKtbzIzCqAXmaM.z6Ujs0yU[(int)(checked((IntPtr)(unchecked((ulong)num2 + (ulong)((long)num)))))] = (num4 << zAb8URrE | num3);
                                num3 = num4 >> 32 - zAb8URrE;
                                num2 += 1U;
                            }
                            ztT1t6JDlZEKtbzIzCqAXmaM.z6Ujs0yU[(int)(checked((IntPtr)(unchecked((ulong)num2 + (ulong)((long)num)))))] = num3;
                        }
                        else
                        {
                            while (num2 < zZW7BdZ0)
                            {
                                ztT1t6JDlZEKtbzIzCqAXmaM.z6Ujs0yU[(int)(checked((IntPtr)(unchecked((ulong)num2 + (ulong)((long)num)))))] = z6Mg5G3Y.z6Ujs0yU[(int)num2];
                                num2 += 1U;
                            }
                        }
                        ztT1t6JDlZEKtbzIzCqAXmaM.zPx1f1l8();
                        result = ztT1t6JDlZEKtbzIzCqAXmaM;
                    }
                    return result;
                }
                public static void zTEl5JihyJsNo(AXmaMClass z6Mg5G3Y, ref uint[] zVPVbXEKsqiYY)
                {
                    uint[] array = zVPVbXEKsqiYY;
                    zVPVbXEKsqiYY = z6Mg5G3Y.z6Ujs0yU;
                    uint[] z6Ujs0yU = z6Mg5G3Y.z6Ujs0yU;
                    uint zZW7BdZ0 = z6Mg5G3Y.zZW7BdZ0;
                    z6Mg5G3Y.z6Ujs0yU = array;
                    uint num = (uint)array.Length;
                    for (uint num2 = 0U; num2 < num; num2 += 1U)
                    {
                        array[(int)num2] = 0U;
                    }
                    uint num3 = 0U;
                    uint num4 = 0U;
                    uint num5 = 0U;
                    while (num5 < zZW7BdZ0)
                    {
                        bool flag = z6Ujs0yU[(int)num3] == 0U;
                        if (!flag)
                        {
                            ulong num6 = 0UL;
                            uint num7 = z6Ujs0yU[(int)num3];
                            uint num8 = num3 + 1U;
                            uint num9 = num4 + 2U * num5 + 1U;
                            uint num10 = num5 + 1U;
                            while (num10 < zZW7BdZ0)
                            {
                                num6 += (ulong)num7 * (ulong)z6Ujs0yU[(int)num8] + (ulong)array[(int)num9];
                                array[(int)num9] = (uint)num6;
                                num6 >>= 32;
                                num10 += 1U;
                                num9 += 1U;
                                num8 += 1U;
                            }
                            bool flag2 = num6 > 0UL;
                            if (flag2)
                            {
                                array[(int)num9] = (uint)num6;
                            }
                        }
                        num5 += 1U;
                        num3 += 1U;
                    }
                    num4 = 0U;
                    uint num11 = 0U;
                    while (num4 < num)
                    {
                        uint num12 = array[(int)num4];
                        array[(int)num4] = (num12 << 1 | num11);
                        num11 = num12 >> 31;
                        num4 += 1U;
                    }
                    bool flag3 = num11 > 0U;
                    if (flag3)
                    {
                        array[(int)num4] = num11;
                    }
                    num3 = 0U;
                    num4 = 0U;
                    uint num13 = num3 + zZW7BdZ0;
                    while (num3 < num13)
                    {
                        ulong num14 = (ulong)z6Ujs0yU[(int)num3] * (ulong)z6Ujs0yU[(int)num3] + (ulong)array[(int)num4];
                        array[(int)num4] = (uint)num14;
                        num14 >>= 32;
                        array[(int)(num4 += 1U)] += (uint)num14;
                        bool flag4 = array[(int)num4] < (uint)num14;
                        if (flag4)
                        {
                            uint num15 = num4;
                            array[(int)(num15 += 1U)] += 1U;
                            while (array[(int)num15++] == 0U)
                            {
                                array[(int)num15] += 1U;
                            }
                        }
                        num3 += 1U;
                        num4 += 1U;
                    }
                    z6Mg5G3Y.zZW7BdZ0 <<= 1;
                    while (array[(int)(z6Mg5G3Y.zZW7BdZ0 - 1U)] == 0U && z6Mg5G3Y.zZW7BdZ0 > 1U)
                    {
                        z6Mg5G3Y.zZW7BdZ0 -= 1U;
                    }
                }
                public static void zFZJkLuDvRCeB(uint[] zfRBKONA, uint z6zvrKF8, uint zvfzNuI, uint[] z6E4jpU4, uint zy5YgaS4, uint zO_onLrc, uint[] zuhFL5Zs, uint zBrYwoUs)
                {
                    uint num = z6zvrKF8;
                    uint num2 = num + zvfzNuI;
                    uint num3 = zy5YgaS4 + zO_onLrc;
                    uint num4 = zBrYwoUs;
                    while (num < num2)
                    {
                        bool flag = zfRBKONA[(int)num] == 0U;
                        if (!flag)
                        {
                            ulong num5 = 0UL;
                            uint num6 = num4;
                            uint num7 = zy5YgaS4;
                            while (num7 < num3)
                            {
                                num5 += (ulong)zfRBKONA[(int)num] * (ulong)z6E4jpU4[(int)num7] + (ulong)zuhFL5Zs[(int)num6];
                                zuhFL5Zs[(int)num6] = (uint)num5;
                                num5 >>= 32;
                                num7 += 1U;
                                num6 += 1U;
                            }
                            bool flag2 = num5 > 0UL;
                            if (flag2)
                            {
                                zuhFL5Zs[(int)num6] = (uint)num5;
                            }
                        }
                        num += 1U;
                        num4 += 1U;
                    }
                }
                public static AXmaMClass.zgF6UnO8 z1pvawiI(AXmaMClass z9RjxOYo, AXmaMClass z8QaM2k8)
                {
                    uint num = z9RjxOYo.zZW7BdZ0;
                    uint num2 = z8QaM2k8.zZW7BdZ0;
                    while (num > 0U && z9RjxOYo.z6Ujs0yU[(int)(num - 1U)] == 0U)
                    {
                        num -= 1U;
                    }
                    while (num2 > 0U && z8QaM2k8.z6Ujs0yU[(int)(num2 - 1U)] == 0U)
                    {
                        num2 -= 1U;
                    }
                    bool flag = num == 0U && num2 == 0U;
                    AXmaMClass.zgF6UnO8 result;
                    if (flag)
                    {
                        result = (AXmaMClass.zgF6UnO8)0;
                    }
                    else
                    {
                        bool flag2 = num < num2;
                        if (flag2)
                        {
                            result = (AXmaMClass.zgF6UnO8)(-1);
                        }
                        else
                        {
                            bool flag3 = num > num2;
                            if (flag3)
                            {
                                result = (AXmaMClass.zgF6UnO8)1;
                            }
                            else
                            {
                                uint num3 = num - 1U;
                                while (num3 != 0U && z9RjxOYo.z6Ujs0yU[(int)num3] == z8QaM2k8.z6Ujs0yU[(int)num3])
                                {
                                    num3 -= 1U;
                                }
                                bool flag4 = z9RjxOYo.z6Ujs0yU[(int)num3] < z8QaM2k8.z6Ujs0yU[(int)num3];
                                if (flag4)
                                {
                                    result = (AXmaMClass.zgF6UnO8)(-1);
                                }
                                else
                                {
                                    bool flag5 = z9RjxOYo.z6Ujs0yU[(int)num3] > z8QaM2k8.z6Ujs0yU[(int)num3];
                                    if (flag5)
                                    {
                                        result = (AXmaMClass.zgF6UnO8)1;
                                    }
                                    else
                                    {
                                        result = (AXmaMClass.zgF6UnO8)0;
                                    }
                                }
                            }
                        }
                    }
                    return result;
                }
                public static AXmaMClass[] zfFp3sqjRMTy1(AXmaMClass zAb8URrE, uint zuhFL5Zs)
                {
                    AXmaMClass ztT1t6JDlZEKtbzIzCqAXmaM = new AXmaMClass((AXmaMClass.zgF6UnO8)1, zAb8URrE.zZW7BdZ0);
                    ulong num = 0UL;
                    uint zZW7BdZ0 = zAb8URrE.zZW7BdZ0;
                    while (zZW7BdZ0-- > 0U)
                    {
                        num <<= 32;
                        num |= (ulong)zAb8URrE.z6Ujs0yU[(int)zZW7BdZ0];
                        ztT1t6JDlZEKtbzIzCqAXmaM.z6Ujs0yU[(int)zZW7BdZ0] = (uint)(num / (ulong)zuhFL5Zs);
                        num %= (ulong)zuhFL5Zs;
                    }
                    ztT1t6JDlZEKtbzIzCqAXmaM.zPx1f1l8();
                    AXmaMClass ztT1t6JDlZEKtbzIzCqAXmaM2 = (uint)num;
                    return new AXmaMClass[]
                    {
                ztT1t6JDlZEKtbzIzCqAXmaM,
                ztT1t6JDlZEKtbzIzCqAXmaM2
                    };
                }
                public static AXmaMClass[] zga2vMhK71NoA(AXmaMClass z9RjxOYo, AXmaMClass z8QaM2k8)
                {
                    bool flag = AXmaMClass.zCVEM1E8.z1pvawiI(z9RjxOYo, z8QaM2k8) == (AXmaMClass.zgF6UnO8)(-1);
                    AXmaMClass[] result;
                    if (flag)
                    {
                        result = new AXmaMClass[]
                        {
                    0,
                    new AXmaMClass(z9RjxOYo)
                        };
                    }
                    else
                    {
                        z9RjxOYo.zPx1f1l8();
                        z8QaM2k8.zPx1f1l8();
                        bool flag2 = z8QaM2k8.zZW7BdZ0 == 1U;
                        if (flag2)
                        {
                            result = AXmaMClass.zCVEM1E8.zfFp3sqjRMTy1(z9RjxOYo, z8QaM2k8.z6Ujs0yU[0]);
                        }
                        else
                        {
                            uint num = z9RjxOYo.zZW7BdZ0 + 1U;
                            int num2 = (int)(z8QaM2k8.zZW7BdZ0 + 1U);
                            uint num3 = 2147483648U;
                            uint num4 = z8QaM2k8.z6Ujs0yU[(int)(z8QaM2k8.zZW7BdZ0 - 1U)];
                            int num5 = 0;
                            int num6 = (int)(z9RjxOYo.zZW7BdZ0 - z8QaM2k8.zZW7BdZ0);
                            while (num3 != 0U && (num4 & num3) == 0U)
                            {
                                num5++;
                                num3 >>= 1;
                            }
                            AXmaMClass ztT1t6JDlZEKtbzIzCqAXmaM = new AXmaMClass((AXmaMClass.zgF6UnO8)1, z9RjxOYo.zZW7BdZ0 - z8QaM2k8.zZW7BdZ0 + 1U);
                            AXmaMClass ztT1t6JDlZEKtbzIzCqAXmaM2 = z9RjxOYo << num5;
                            uint[] z6Ujs0yU = ztT1t6JDlZEKtbzIzCqAXmaM2.z6Ujs0yU;
                            z8QaM2k8 <<= num5;
                            int i = (int)(num - z8QaM2k8.zZW7BdZ0);
                            int num7 = (int)(num - 1U);
                            uint num8 = z8QaM2k8.z6Ujs0yU[(int)(z8QaM2k8.zZW7BdZ0 - 1U)];
                            ulong num9 = (ulong)z8QaM2k8.z6Ujs0yU[(int)(z8QaM2k8.zZW7BdZ0 - 2U)];
                            while (i > 0)
                            {
                                ulong num10 = ((ulong)z6Ujs0yU[num7] << 32) + (ulong)z6Ujs0yU[num7 - 1];
                                ulong num11 = num10 / (ulong)num8;
                                ulong num12 = num10 % (ulong)num8;
                                bool flag4;
                                do
                                {
                                    bool flag3 = num11 == 4294967296UL || num11 * num9 > (num12 << 32) + (ulong)z6Ujs0yU[num7 - 2];
                                    if (!flag3)
                                    {
                                        break;
                                    }
                                    num11 -= 1UL;
                                    num12 += (ulong)num8;
                                    flag4 = (num12 < 4294967296UL);
                                }
                                while (flag4);
                                uint num13 = 0U;
                                int num14 = num7 - num2 + 1;
                                ulong num15 = 0UL;
                                uint num16 = (uint)num11;
                                do
                                {
                                    num15 += (ulong)z8QaM2k8.z6Ujs0yU[(int)num13] * (ulong)num16;
                                    uint num17 = z6Ujs0yU[num14];
                                    z6Ujs0yU[num14] -= (uint)num15;
                                    num15 >>= 32;
                                    bool flag5 = z6Ujs0yU[num14] > num17;
                                    if (flag5)
                                    {
                                        num15 += 1UL;
                                    }
                                    num13 += 1U;
                                    num14++;
                                }
                                while ((ulong)num13 < (ulong)((long)num2));
                                num14 = num7 - num2 + 1;
                                num13 = 0U;
                                bool flag6 = num15 > 0UL;
                                if (flag6)
                                {
                                    num16 -= 1U;
                                    ulong num18 = 0UL;
                                    do
                                    {
                                        num18 = (ulong)z6Ujs0yU[num14] + (ulong)z8QaM2k8.z6Ujs0yU[(int)num13] + num18;
                                        z6Ujs0yU[num14] = (uint)num18;
                                        num18 >>= 32;
                                        num13 += 1U;
                                        num14++;
                                    }
                                    while ((ulong)num13 < (ulong)((long)num2));
                                }
                                ztT1t6JDlZEKtbzIzCqAXmaM.z6Ujs0yU[num6--] = num16;
                                num7--;
                                i--;
                            }
                            ztT1t6JDlZEKtbzIzCqAXmaM.zPx1f1l8();
                            ztT1t6JDlZEKtbzIzCqAXmaM2.zPx1f1l8();
                            AXmaMClass[] array = new AXmaMClass[]
                            {
                        ztT1t6JDlZEKtbzIzCqAXmaM,
                        ztT1t6JDlZEKtbzIzCqAXmaM2
                            };
                            bool flag7 = num5 != 0;
                            if (flag7)
                            {
                                AXmaMClass[] array2 = array;
                                array2[1] = array2[1] >> num5;
                            }
                            result = array;
                        }
                    }
                    return result;
                }
            }
            public AXmaMClass(uint z08fgjBM)
            {
                this.z6Ujs0yU = new uint[]
                {
            z08fgjBM
                };
            }
            public static implicit operator AXmaMClass(uint zJs1ZIoY)
            {
                return new AXmaMClass(zJs1ZIoY);
            }
            public static implicit operator AXmaMClass(int zJs1ZIoY)
            {
                return new AXmaMClass((uint)zJs1ZIoY);
            }
            public AXmaMClass(AXmaMClass z6Mg5G3Y)
            {
                this.z6Ujs0yU = (uint[])z6Mg5G3Y.z6Ujs0yU.Clone();
                this.zZW7BdZ0 = z6Mg5G3Y.zZW7BdZ0;
            }
            public AXmaMClass(AXmaMClass.zgF6UnO8 z4c1gASc, uint ztYGiv4o)
            {
                this.z6Ujs0yU = new uint[ztYGiv4o];
                this.zZW7BdZ0 = ztYGiv4o;
            }
            public enum zgF6UnO8
            {

            }
        }
        public sealed class RsLAf
        {
            public static byte[] zzxakJf3TMA5L(byte[] zfRBKONA)
            {
                int num = 0;
                while (zfRBKONA[num++] == 0 && num < zfRBKONA.Length)
                {
                }
                num--;
                bool flag = num > 0;
                byte[] result;
                if (flag)
                {
                    byte[] array = new byte[zfRBKONA.Length - num];
                    Buffer.BlockCopy(zfRBKONA, num, array, 0, array.Length);
                    result = array;
                }
                else
                {
                    result = zfRBKONA;
                }
                return result;
            }
            public static byte[] zfcV5mGdQJrLv(byte[] zfRBKONA, int z2mOvfRs)
            {
                byte[] array = new byte[z2mOvfRs];
                Buffer.BlockCopy(zfRBKONA, 0, array, array.Length - zfRBKONA.Length, zfRBKONA.Length);
                return array;
            }
            public static byte[] z6jALjshbV8BZ(JadRzF0VXk z0AdMAyk, byte[] zUJzVkB8)
            {
                return z0AdMAyk.zHnajSQA(zUJzVkB8);
            }
        }
        public static class FAc8zIk
        {
            private static byte[] zNyS1tM9ga4wbwHD04TJbx4c6F4Bv;
            private static byte[] zy5QamzDnuFAARr_hd2h5faRdtiCx;
            private static short z80h7vM4srRE596jmQxnHSCJAFHR;
            private static ConcurrentDictionary<int, string> zZPvgUe6rFsS0VovvCCwMhN3VH1p;
            private static int zHa2L8oOBPhxzAJ8Xs3IrRvKU5026;
            private static FAc8zIk.z6lhAq7523qmBagarXHx8gPNDIChf zcHcNOh5xlZ0MwVYKOFfcmQMr0y1c;
            private enum z6lhAq7523qmBagarXHx8gPNDIChf
            {

            }
            private static void zwkhVeQeo6L2IXTzg0Gl0MjTZad(byte[] zfjaGdRP3n1BmjmCIn5tUphpAAPOd, int z9fJGVntRnW8WG_b_tFSgHrU, byte[] zJWkv0n7qNS9yBEmth85WXA9QBmwm)
            {
                int i = 0;
                int num = 0;
                int num2 = 128;
                int num3 = zJWkv0n7qNS9yBEmth85WXA9QBmwm.Length;
                while (i < num3)
                {
                    if ((num2 <<= 1) == 256)
                    {
                        num2 = 1;
                        num = (int)zfjaGdRP3n1BmjmCIn5tUphpAAPOd[z9fJGVntRnW8WG_b_tFSgHrU++];
                    }
                    if ((num & num2) != 0)
                    {
                        int num4 = (zfjaGdRP3n1BmjmCIn5tUphpAAPOd[z9fJGVntRnW8WG_b_tFSgHrU] >> 2) + 3;
                        int num5 = ((int)zfjaGdRP3n1BmjmCIn5tUphpAAPOd[z9fJGVntRnW8WG_b_tFSgHrU] << 8 | (int)zfjaGdRP3n1BmjmCIn5tUphpAAPOd[z9fJGVntRnW8WG_b_tFSgHrU + 1]) & 1023;
                        z9fJGVntRnW8WG_b_tFSgHrU += 2;
                        int num6 = i - num5;
                        if (num6 < 0)
                        {
                            return;
                        }
                        while (--num4 >= 0)
                        {
                            if (i >= num3)
                            {
                                break;
                            }
                            zJWkv0n7qNS9yBEmth85WXA9QBmwm[i++] = zJWkv0n7qNS9yBEmth85WXA9QBmwm[num6++];
                        }
                    }
                    else
                    {
                        zJWkv0n7qNS9yBEmth85WXA9QBmwm[i++] = zfjaGdRP3n1BmjmCIn5tUphpAAPOd[z9fJGVntRnW8WG_b_tFSgHrU++];
                    }
                }
            }
            private static byte[] z7GeXLxkO9_C6fFBzIX3iBd8Be4tq(AssemblyName zK6abyZMYeaKkpixKmfcwnEU)
            {
                byte[] array = zK6abyZMYeaKkpixKmfcwnEU.GetPublicKeyToken();
                if (array != null && array.Length == 0)
                {
                    array = null;
                }
                return array;
            }
            private static AssemblyName zey0tAVxNKBDpcQY6YvqTEzeJzwL(Assembly z23UmgD9v0VScPB1adcAOUdLTJA4A)
            {
                AssemblyName result;
                try
                {
                    result = z23UmgD9v0VScPB1adcAOUdLTJA4A.GetName();
                }
                catch
                {
                    result = new AssemblyName(z23UmgD9v0VScPB1adcAOUdLTJA4A.FullName);
                }
                return result;
            }
            private static FAc8zIk.zGoMFo0wVbWPARQ6zBpgMEeyzbxg_ zU3Eq4y5WwrdzOcCnfj17fYn3QRZo;
            private sealed class zGoMFo0wVbWPARQ6zBpgMEeyzbxg_
            {
                private Stream znvShx1H46nAMxz3yctGHqVRh8pH;
                private byte[] zMhPeU5leuWHPElMGBjtY2GqX_gGr;
                public void zKD99by0FY1ISVLI990BkOfe1pfVs()
                {
                    Stream stream = this.znvShx1H46nAMxz3yctGHqVRh8pH;
                    this.znvShx1H46nAMxz3yctGHqVRh8pH = null;
                    if (stream != null)
                    {
                        stream.Close();
                    }
                    this.zMhPeU5leuWHPElMGBjtY2GqX_gGr = null;
                }
                public int zw8vDfDsVT1lMCprUxoSn32CoZF0o()
                {
                    this.z2tJ40EsSnVj456Ix_xMfTc(4);
                    return (int)this.zMhPeU5leuWHPElMGBjtY2GqX_gGr[0] | (int)this.zMhPeU5leuWHPElMGBjtY2GqX_gGr[1] << 8 | (int)this.zMhPeU5leuWHPElMGBjtY2GqX_gGr[2] << 16 | (int)this.zMhPeU5leuWHPElMGBjtY2GqX_gGr[3] << 24;
                }
                public Stream z8OV16Vj5hy80RxKFi0iSPyFDpSlP()
                {
                    return this.znvShx1H46nAMxz3yctGHqVRh8pH;
                }
                public byte[] zzHHzizoYpwok9QfH77JIwVFUlegf(int zmbmU3Uop1Cb8jzYJFRdMzI8svLWM)
                {
                    if (zmbmU3Uop1Cb8jzYJFRdMzI8svLWM < 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    byte[] array = new byte[zmbmU3Uop1Cb8jzYJFRdMzI8svLWM];
                    int num = 0;
                    do
                    {
                        int num2 = this.znvShx1H46nAMxz3yctGHqVRh8pH.Read(array, num, zmbmU3Uop1Cb8jzYJFRdMzI8svLWM);
                        if (num2 == 0)
                        {
                            break;
                        }
                        num += num2;
                        zmbmU3Uop1Cb8jzYJFRdMzI8svLWM -= num2;
                    }
                    while (zmbmU3Uop1Cb8jzYJFRdMzI8svLWM > 0);
                    if (num != array.Length)
                    {
                        byte[] array2 = new byte[num];
                        Buffer.BlockCopy(array, 0, array2, 0, num);
                        array = array2;
                    }
                    return array;
                }
                public zGoMFo0wVbWPARQ6zBpgMEeyzbxg_(Stream zJLAJngeeMdUOf7lGBY08peOTUv4_)
                {
                    this.znvShx1H46nAMxz3yctGHqVRh8pH = zJLAJngeeMdUOf7lGBY08peOTUv4_;
                    this.zMhPeU5leuWHPElMGBjtY2GqX_gGr = new byte[4];
                }
                private static void zqw0M8AqrU2do5n1Rh_tHHiY4vbBL()
                {
                    throw new EndOfStreamException();
                }
                private void z2tJ40EsSnVj456Ix_xMfTc(int zWxZJZZx1FCVHQDXYju9CDWcHOVdF)
                {
                    int num = 0;
                    if (zWxZJZZx1FCVHQDXYju9CDWcHOVdF == 1)
                    {
                        int num2 = this.znvShx1H46nAMxz3yctGHqVRh8pH.ReadByte();
                        if (num2 == -1)
                        {
                            FAc8zIk.zGoMFo0wVbWPARQ6zBpgMEeyzbxg_.zqw0M8AqrU2do5n1Rh_tHHiY4vbBL();
                        }
                        this.zMhPeU5leuWHPElMGBjtY2GqX_gGr[0] = (byte)num2;
                        return;
                    }
                    do
                    {
                        int num2 = this.znvShx1H46nAMxz3yctGHqVRh8pH.Read(this.zMhPeU5leuWHPElMGBjtY2GqX_gGr, num, zWxZJZZx1FCVHQDXYju9CDWcHOVdF - num);
                        if (num2 == 0)
                        {
                            FAc8zIk.zGoMFo0wVbWPARQ6zBpgMEeyzbxg_.zqw0M8AqrU2do5n1Rh_tHHiY4vbBL();
                        }
                        num += num2;
                    }
                    while (num < zWxZJZZx1FCVHQDXYju9CDWcHOVdF);
                }
                public short zWpQMWnCAv9OI_5sEfjUOUcBJmj7h()
                {
                    this.z2tJ40EsSnVj456Ix_xMfTc(2);
                    return (short)((int)this.zMhPeU5leuWHPElMGBjtY2GqX_gGr[0] | (int)this.zMhPeU5leuWHPElMGBjtY2GqX_gGr[1] << 8);
                }
            }
            private static int z313U3Q7HCcwwGBXC9Eym4hofcpo;
            private static int zb4vQ6MMZ08FY6mn8C5tr0g6AHjqb;
            [MethodImpl(MethodImplOptions.NoInlining)]
            static FAc8zIk()
            {
                int num = -434859188;
                int num2 = -1972227979 - num;
                FAc8zIk.zZPvgUe6rFsS0VovvCCwMhN3VH1p = new ConcurrentDictionary<int, string>();
                FAc8zIk.zHa2L8oOBPhxzAJ8Xs3IrRvKU5026 += ~(-(~(-(-(~(~(-(~(num ^ -1119853988 ^ num2)))))))));
                FAc8zIk.zcHcNOh5xlZ0MwVYKOFfcmQMr0y1c = ((FAc8zIk.z6lhAq7523qmBagarXHx8gPNDIChf)16 | FAc8zIk.zcHcNOh5xlZ0MwVYKOFfcmQMr0y1c);
            }
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static string z2uo70I4(int zHiTbEPCuAf1_HA5TbObJz0pKY33)
            {
                string result;
                if (FAc8zIk.zZPvgUe6rFsS0VovvCCwMhN3VH1p.TryGetValue(zHiTbEPCuAf1_HA5TbObJz0pKY33, out result))
                {
                    return result;
                }
                return FAc8zIk.zHzF4PdmFm5yuESAzLAqVxrXVDCu(zHiTbEPCuAf1_HA5TbObJz0pKY33, true);
            }
            [MethodImpl(MethodImplOptions.NoInlining)]
            private static string zHzF4PdmFm5yuESAzLAqVxrXVDCu(int zHiTbEPCuAf1_HA5TbObJz0pKY33, bool zHMbIdVsstV_19wrkEgwsRLyVTqQ3)
            {
                int num = -776680653;
                int num2 = 1993672853 ^ num;
                string text = null;
                byte[] array;
                int num18;
                int num19;
                int num20;
                int num21;
                int num22;
                byte[] array4;
                byte[] array5;
                do
                {
                    ConcurrentDictionary<int, string> obj = FAc8zIk.zZPvgUe6rFsS0VovvCCwMhN3VH1p;
                    lock (obj)
                    {
                        int num5;
                        if (FAc8zIk.zU3Eq4y5WwrdzOcCnfj17fYn3QRZo == null)
                        {
                            Assembly executingAssembly = Assembly.GetExecutingAssembly();
                            Assembly z23UmgD9v0VScPB1adcAOUdLTJA4A = Assembly.GetCallingAssembly();
                            FAc8zIk.zb4vQ6MMZ08FY6mn8C5tr0g6AHjqb |= 2033131867 - num - num2;
                            Assembly assembly = executingAssembly;
                            StringBuilder stringBuilder = new StringBuilder();
                            int num3 = (-1456761001 ^ num) + num2;
                            stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
                            num3 = (1494789845 - num ^ num2);
                            stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
                            num3 = (383264923 ^ num) - num2;
                            stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
                            num3 = 1247225742 - num + num2;
                            stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
                            num3 = -173205380 + num - num2;
                            stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
                            num3 = (num ^ -1457678512) + num2;
                            stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
                            num3 = -710076290 + num - num2;
                            stringBuilder.Append((char)num3);
                            Stream manifestResourceStream = assembly.GetManifestResourceStream(stringBuilder.ToString());
                            FAc8zIk.zU3Eq4y5WwrdzOcCnfj17fYn3QRZo = new FAc8zIk.zGoMFo0wVbWPARQ6zBpgMEeyzbxg_(manifestResourceStream);
                            short num4 = (short)(FAc8zIk.zU3Eq4y5WwrdzOcCnfj17fYn3QRZo.zWpQMWnCAv9OI_5sEfjUOUcBJmj7h() ^ (short)(-(short)(~(short)(~(short)(-(short)(~(short)(-(short)(~(short)(-(short)(~(short)(1993700153 ^ num ^ num2)))))))))));
                            if (num4 == 0)
                            {
                                FAc8zIk.z80h7vM4srRE596jmQxnHSCJAFHR = ((short)(FAc8zIk.zU3Eq4y5WwrdzOcCnfj17fYn3QRZo.zWpQMWnCAv9OI_5sEfjUOUcBJmj7h() ^ (short)(-(short)(~(short)(-(short)(~(short)(~(short)(-(short)(-(short)(~(short)(~(short)(710086956 - num + num2))))))))))));
                            }
                            else
                            {
                                FAc8zIk.zy5QamzDnuFAARr_hd2h5faRdtiCx = FAc8zIk.zU3Eq4y5WwrdzOcCnfj17fYn3QRZo.zzHHzizoYpwok9QfH77JIwVFUlegf((int)num4);
                            }
                            z23UmgD9v0VScPB1adcAOUdLTJA4A = executingAssembly;
                            AssemblyName zK6abyZMYeaKkpixKmfcwnEU = FAc8zIk.zey0tAVxNKBDpcQY6YvqTEzeJzwL(z23UmgD9v0VScPB1adcAOUdLTJA4A);
                            FAc8zIk.zNyS1tM9ga4wbwHD04TJbx4c6F4Bv = FAc8zIk.z7GeXLxkO9_C6fFBzIX3iBd8Be4tq(zK6abyZMYeaKkpixKmfcwnEU);
                            num5 = FAc8zIk.zHa2L8oOBPhxzAJ8Xs3IrRvKU5026;
                            num5 ^= (num ^ 644212354) - num2;
                            FAc8zIk.zHa2L8oOBPhxzAJ8Xs3IrRvKU5026 = 0;
                            long num6 = Uey87mYmw.z2uo70I4();
                            num5 ^= (int)((uint)num6);
                            num5 ^= 1576534046 - num + num2;
                            num5 ^= (num ^ -979510139) - num2;
                            int num7 = num5;
                            int num8 = num7;
                            int num9 = num8 - (1527852452 - num + num2) ^ (-1522653539 ^ num ^ num2);
                            int num10 = 0;
                            int za864OmQ = num9;
                            Yfzf1k<int> enumerator = ((BY4t_7dL4c<int>)new DnS90.zlAP7WS4(-2031521499 + num | num2)
                            {
                                za864OmQ = za864OmQ
                            }).GetEnumerator();
                            try
                            {
                                while (enumerator.zjvUHwnVuaKKBRLGPYUVNc0xlD7U6a9TQyo6pdQMe4nSP_KlWgLc61H3KLE9RWCtgHSF4wI())
                                {
                                    int num11 = enumerator.zdclzXzxb1ekfNClJKzTiCVS2izYAXQ5uIydZWmgxBeSHpipkobt8A0kgoDadRtQTjfh5lcuE5xdQEzw();
                                    num9 ^= num11 - num10;
                                    num10 += num9 >> 1;
                                }
                            }
                            finally
                            {
                                if (enumerator != null)
                                {
                                    enumerator.zcBVCa88Tj1Bl8OoRPzs3_BLpDGcsUnbF0pqVOYfpdCLKQK1FYQoMQIwPQ58dQoxHJ7Xl02XgjhnBoCykQ();
                                }
                            }
                            int num12 = num9;
                            num5 ^= num + -709369435 - num2 + -(~(-(~(-(~(~(-(-(~(~(-1993673147 ^ num ^ num2)))))))))));
                            int num13 = (2031526790 - num - num2) * num12 % ((-1947123340 ^ num) + num2);
                            num5 ^= -(~(-(~(-(~(~(-(~(1787961055 + num - num2)))))))));
                            num5 += num13;
                            FAc8zIk.zb4vQ6MMZ08FY6mn8C5tr0g6AHjqb = ((FAc8zIk.zb4vQ6MMZ08FY6mn8C5tr0g6AHjqb & (2052261895 - num ^ num2)) ^ (num ^ -1993695763) + num2);
                            FAc8zIk.z313U3Q7HCcwwGBXC9Eym4hofcpo = num5;
                            if ((0 & -(~(~(-(~(-(~(-(~(-(~((-710084513) + num - num2)))))))))))) == 0)
                            {
                                FAc8zIk.zb4vQ6MMZ08FY6mn8C5tr0g6AHjqb = 710128455 - num + num2;
                            }
                        }
                        else
                        {
                            num5 = FAc8zIk.z313U3Q7HCcwwGBXC9Eym4hofcpo;
                        }
                        if (FAc8zIk.zb4vQ6MMZ08FY6mn8C5tr0g6AHjqb == (1993712431 ^ num ^ num2))
                        {
                            text = new string(new char[]
                            {
                        (char)(-710084405 + num - num2),
                        '0',
                        (char)((-1993672831 ^ num) + num2)
                            });
                            return text;
                        }
                        int num14 = zHiTbEPCuAf1_HA5TbObJz0pKY33 ^ num + 1848602636 - num2 ^ num5;
                        num14 ^= (num ^ 444615359 ^ num2);
                        FAc8zIk.zU3Eq4y5WwrdzOcCnfj17fYn3QRZo.z8OV16Vj5hy80RxKFi0iSPyFDpSlP().Position = (long)num14;
                        if (FAc8zIk.zy5QamzDnuFAARr_hd2h5faRdtiCx != null)
                        {
                            array = FAc8zIk.zy5QamzDnuFAARr_hd2h5faRdtiCx;
                        }
                        else
                        {
                            short num15;
                            if (FAc8zIk.z80h7vM4srRE596jmQxnHSCJAFHR == -1)
                            {
                                num15 = (short)((int)FAc8zIk.zU3Eq4y5WwrdzOcCnfj17fYn3QRZo.zWpQMWnCAv9OI_5sEfjUOUcBJmj7h() ^ 710106768 - num + num2 ^ num14);
                            }
                            else
                            {
                                num15 = FAc8zIk.z80h7vM4srRE596jmQxnHSCJAFHR;
                            }
                            if (num15 == 0)
                            {
                                array = null;
                            }
                            else
                            {
                                array = FAc8zIk.zU3Eq4y5WwrdzOcCnfj17fYn3QRZo.zzHHzizoYpwok9QfH77JIwVFUlegf((int)num15);
                                for (int num16 = 0; num16 != array.Length; num16 = 1 + num16)
                                {
                                    byte[] array2 = array;
                                    int num17 = num16;
                                    array2[num17] ^= (byte)(FAc8zIk.z313U3Q7HCcwwGBXC9Eym4hofcpo >> ((num16 & 3) << 3));
                                }
                            }
                        }
                        num18 = (FAc8zIk.zU3Eq4y5WwrdzOcCnfj17fYn3QRZo.zw8vDfDsVT1lMCprUxoSn32CoZF0o() ^ num14 ^ -(~(-(~(-(~(~(-(~(num + -849648538 - num2))))))))) ^ num5);
                        if (num18 == (710084491 - num | num2))
                        {
                            byte[] array3 = FAc8zIk.zU3Eq4y5WwrdzOcCnfj17fYn3QRZo.zzHHzizoYpwok9QfH77JIwVFUlegf(4);
                            zHiTbEPCuAf1_HA5TbObJz0pKY33 = (2122620059 ^ num ^ num2 ^ num5);
                            zHiTbEPCuAf1_HA5TbObJz0pKY33 = (((int)array3[2] | (int)array3[3] << 16 | (int)array3[0] << 8 | (int)array3[1] << 24) ^ -zHiTbEPCuAf1_HA5TbObJz0pKY33);
                            goto IL_13;
                        }
                        num19 = 711692307 - num + num2;
                        num20 = FAc8zIk.zb4vQ6MMZ08FY6mn8C5tr0g6AHjqb;
                        num21 = num18;
                        num22 = num20 - 12;
                        num18 &= -441649038 + num - num2;
                        array4 = FAc8zIk.zU3Eq4y5WwrdzOcCnfj17fYn3QRZo.zzHHzizoYpwok9QfH77JIwVFUlegf(num18);
                        array5 = FAc8zIk.zNyS1tM9ga4wbwHD04TJbx4c6F4Bv;
                    }
                    goto IL_4E4;
                IL_13:;
                }
                while (!FAc8zIk.zZPvgUe6rFsS0VovvCCwMhN3VH1p.TryGetValue(zHiTbEPCuAf1_HA5TbObJz0pKY33, out text));
                return text;
            IL_4E4:
                bool flag2 = (num21 & (1227552617 ^ num) + num2) != 0;
                bool flag3 = (num21 & (num + 1437399155 ^ num2)) != 0;
                bool flag4 = (num21 & 1246955405 - num + num2) != 0;
                byte[] array6 = array;
                byte[] array7 = array4;
                byte[] array8 = array6;
                byte b = array8[1];
                int num23 = array7.Length;
                byte b2 = (byte)(11 + num23 ^ (int)(7 + b));
                uint num24 = (uint)(((int)array8[0] | (int)array8[2] << 8) + ((int)b2 << 3));
                ushort num25 = 0;
                for (int i = 0; i < num23; i++)
                {
                    if ((i & 1) == 0)
                    {
                        num24 = num24 * (uint)(-710036184 + num ^ num2) + (uint)((1983687002 ^ num) - num2);
                        num25 = (ushort)(num24 >> 16);
                    }
                    byte b3 = (byte)num25;
                    num25 = (ushort)(num25 >> 8);
                    byte b4 = array7[i];
                    array7[i] = (byte)(b4 ^ b ^ 3 + b2 ^ b3);
                    b2 = b4;
                }
                array4 = array7;
                if (array5 != null != (num19 != num20))
                {
                    for (int j = 0; j < num18; j++)
                    {
                        byte b5 = array5[7 & j];
                        b5 = (byte)((int)b5 << 3 | b5 >> 5);
                        array4[j] ^= b5;
                    }
                }
                int num26;
                byte[] array9;
                if (!flag3)
                {
                    num26 = num18;
                    array9 = array4;
                }
                else
                {
                    num26 = ((int)array4[2] | (int)array4[0] << 16 | (int)array4[3] << 8 | (int)array4[1] << 24);
                    array9 = new byte[num26];
                    FAc8zIk.zwkhVeQeo6L2IXTzg0Gl0MjTZad(array4, 4, array9);
                }
                if (flag2 && num22 == num19 - 12)
                {
                    char[] array10 = new char[num26];
                    for (int k = 0; k < num26; k = 1 + k)
                    {
                        array10[k] = (char)array9[k];
                    }
                    text = new string(array10);
                }
                else
                {
                    text = Encoding.Unicode.GetString(array9, 0, array9.Length);
                }
                num22 += 710084620 - num + num2 + (3 & num22) << 5;
                if (num22 != num19 - 12 + ((-710084442 + num ^ num2) + (num19 - 12 & 3) << 5))
                {
                    int num27 = zHiTbEPCuAf1_HA5TbObJz0pKY33 + num18 ^ (-1994895903 ^ num) + num2 ^ (num22 & (-710083720 + num ^ num2));
                    StringBuilder stringBuilder = new StringBuilder();
                    int num3 = 710084581 - num + num2;
                    stringBuilder.Append((char)((byte)num3));
                    text = num27.ToString(stringBuilder.ToString());
                }
                if (!flag4 && zHMbIdVsstV_19wrkEgwsRLyVTqQ3)
                {
                    text = string.Intern(text);
                    FAc8zIk.zZPvgUe6rFsS0VovvCCwMhN3VH1p[zHiTbEPCuAf1_HA5TbObJz0pKY33] = text;
                    if (FAc8zIk.zZPvgUe6rFsS0VovvCCwMhN3VH1p.Count == -710061496 + num - num2)
                    {
                        bool flag5 = false;
                        ConcurrentDictionary<int, string> obj2 = FAc8zIk.zZPvgUe6rFsS0VovvCCwMhN3VH1p;
                        try
                        {
                            Monitor.Enter(obj2, ref flag5);
                            FAc8zIk.zU3Eq4y5WwrdzOcCnfj17fYn3QRZo.zKD99by0FY1ISVLI990BkOfe1pfVs();
                            FAc8zIk.zU3Eq4y5WwrdzOcCnfj17fYn3QRZo = null;
                            FAc8zIk.zy5QamzDnuFAARr_hd2h5faRdtiCx = null;
                            FAc8zIk.zNyS1tM9ga4wbwHD04TJbx4c6F4Bv = null;
                        }
                        finally
                        {
                            if (flag5)
                            {
                                Monitor.Exit(obj2);
                            }
                        }
                    }
                }
                return text;
            }
        }
        public interface Yfzf1k<zlAP7WS4> : qQIm9LoCGeisrs2N6gx6vsbcKJileQc6lC4jzqWytze4, qmX5GgA7KxW7z_9hiz1UGf5dCa9fpYN5dk0i2NBjWdOE
        {
            zlAP7WS4 zdclzXzxb1ekfNClJKzTiCVS2izYAXQ5uIydZWmgxBeSHpipkobt8A0kgoDadRtQTjfh5lcuE5xdQEzw();
        }
        public interface qQIm9LoCGeisrs2N6gx6vsbcKJileQc6lC4jzqWytze4
        {
            bool zjvUHwnVuaKKBRLGPYUVNc0xlD7U6a9TQyo6pdQMe4nSP_KlWgLc61H3KLE9RWCtgHSF4wI();

            object zdclzXzxb1ekfNClJKzTiCVS2izYAXQ5uIydZWmgxBeSHpipkobt8A0kgoDadRtQTjfh5lcuE5xdQEzw();

            void zj6fo_ej1NsFwWiAaGRGlkVfRI6e3BTRz9dJQW0kXJQ_eVc32yIKGEeFEefxaTFH4TcjDhoVYuJmc7VxrzUYjbEw();
        }
        public interface qmX5GgA7KxW7z_9hiz1UGf5dCa9fpYN5dk0i2NBjWdOE
        {
            void zcBVCa88Tj1Bl8OoRPzs3_BLpDGcsUnbF0pqVOYfpdCLKQK1FYQoMQIwPQ58dQoxHJ7Xl02XgjhnBoCykQ();
        }
        public static class Uey87mYmw
        {
            private static class zWgRAVWAydUff3XeTjHjC2IWwqdJT
            {
                public static int zF258t9YWmsl_njRV3Z8vJPbe78_(int z5Gm2v3geY0P0bsNEPUneONdn8Nc, int zCSicXJhS48EJCnKpFXiVNeqy5n)
                {
                    return z5Gm2v3geY0P0bsNEPUneONdn8Nc ^ zCSicXJhS48EJCnKpFXiVNeqy5n - ~(-(~(-(-(~(~(-(~2025860507))))))));
                }

                public static int zFckdjBhjgtpWnF86jKJEslwNNDh(int z5Gm2v3geY0P0bsNEPUneONdn8Nc, int zCSicXJhS48EJCnKpFXiVNeqy5n)
                {
                    return z5Gm2v3geY0P0bsNEPUneONdn8Nc - -(~(-(~(-(~(~(-(~-1817286474)))))))) ^ zCSicXJhS48EJCnKpFXiVNeqy5n + -(~(-(~(-(~(-(~(~(-(~1469460067))))))))));
                }

                public static int zQk9sG6NtHfZfL4NJr_dHtgLAb2hc(int z5Gm2v3geY0P0bsNEPUneONdn8Nc, int zCSicXJhS48EJCnKpFXiVNeqy5n)
                {
                    return z5Gm2v3geY0P0bsNEPUneONdn8Nc ^ (zCSicXJhS48EJCnKpFXiVNeqy5n - -(~(-(~(~(-(-(~(~(-(~-1960752828)))))))))) ^ z5Gm2v3geY0P0bsNEPUneONdn8Nc - zCSicXJhS48EJCnKpFXiVNeqy5n);
                }
            }
            private sealed class zQUrYtJA
            {
                [MethodImpl(MethodImplOptions.NoInlining)]
                public static int zQMvNzDHSaeMIDLJ7gxz5T4pkmgWk()
                {
                    return Uey87mYmw.zWgRAVWAydUff3XeTjHjC2IWwqdJT.zF258t9YWmsl_njRV3Z8vJPbe78_(Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw.zWS8KzgI)), Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw.zcspo_u4)) ^ Uey87mYmw.zWgRAVWAydUff3XeTjHjC2IWwqdJT.zFckdjBhjgtpWnF86jKJEslwNNDh(Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw.zQUrYtJA)), Uey87mYmw.zWgRAVWAydUff3XeTjHjC2IWwqdJT.zQk9sG6NtHfZfL4NJr_dHtgLAb2hc(Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw.zOsDyjc)), Uey87mYmw.zcspo_u4.zQMvNzDHSaeMIDLJ7gxz5T4pkmgWk())));
                }
            }
            private sealed class zcspo_u4
            {
                [MethodImpl(MethodImplOptions.NoInlining)]
                public static int zQMvNzDHSaeMIDLJ7gxz5T4pkmgWk()
                {
                    return Uey87mYmw.zWgRAVWAydUff3XeTjHjC2IWwqdJT.zQk9sG6NtHfZfL4NJr_dHtgLAb2hc(Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw.zcspo_u4)), Uey87mYmw.zWgRAVWAydUff3XeTjHjC2IWwqdJT.zF258t9YWmsl_njRV3Z8vJPbe78_(Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw.zvCdVC1k)), Uey87mYmw.zWgRAVWAydUff3XeTjHjC2IWwqdJT.zFckdjBhjgtpWnF86jKJEslwNNDh(Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw.zQUrYtJA)), Uey87mYmw.zWgRAVWAydUff3XeTjHjC2IWwqdJT.zQk9sG6NtHfZfL4NJr_dHtgLAb2hc(Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw.zWS8KzgI)), Uey87mYmw.zWgRAVWAydUff3XeTjHjC2IWwqdJT.zF258t9YWmsl_njRV3Z8vJPbe78_(Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw.zuW2VD6s)), Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw.zOsDyjc)))))));
                }
            }

            private sealed class zWS8KzgI
            {
                [MethodImpl(MethodImplOptions.NoInlining)]
                public static int zQMvNzDHSaeMIDLJ7gxz5T4pkmgWk()
                {
                    return Uey87mYmw.zWgRAVWAydUff3XeTjHjC2IWwqdJT.zQk9sG6NtHfZfL4NJr_dHtgLAb2hc(Uey87mYmw.zWgRAVWAydUff3XeTjHjC2IWwqdJT.zF258t9YWmsl_njRV3Z8vJPbe78_(Uey87mYmw.zQUrYtJA.zQMvNzDHSaeMIDLJ7gxz5T4pkmgWk() ^ ~(-(~(-(-(~(~(-(~-527758449)))))))), Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw.zcspo_u4))), Uey87mYmw.zWgRAVWAydUff3XeTjHjC2IWwqdJT.zFckdjBhjgtpWnF86jKJEslwNNDh(Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw.zvCdVC1k)) ^ Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw.zOsDyjc)), -(~(~(-(-(~(-(~(~-358997306))))))))));
                }
            }
            private sealed class zOsDyjc
            {
                [MethodImpl(MethodImplOptions.NoInlining)]
                public static int zQMvNzDHSaeMIDLJ7gxz5T4pkmgWk()
                {
                    return Uey87mYmw.zWgRAVWAydUff3XeTjHjC2IWwqdJT.zF258t9YWmsl_njRV3Z8vJPbe78_(Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw.zOsDyjc)), Uey87mYmw.zWgRAVWAydUff3XeTjHjC2IWwqdJT.zQk9sG6NtHfZfL4NJr_dHtgLAb2hc(Uey87mYmw.zWgRAVWAydUff3XeTjHjC2IWwqdJT.zFckdjBhjgtpWnF86jKJEslwNNDh(Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw.zuW2VD6s)), Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw.zvCdVC1k))), Uey87mYmw.zWgRAVWAydUff3XeTjHjC2IWwqdJT.zQk9sG6NtHfZfL4NJr_dHtgLAb2hc(Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw.zWS8KzgI)) ^ ~(-(-(~(-(~(-(~(~(-(~-1541122564)))))))))), Uey87mYmw.zuW2VD6s.zQMvNzDHSaeMIDLJ7gxz5T4pkmgWk())));
                }
            }
            private sealed class zuW2VD6s
            {
                [MethodImpl(MethodImplOptions.NoInlining)]
                public static int zQMvNzDHSaeMIDLJ7gxz5T4pkmgWk()
                {
                    return Uey87mYmw.zWgRAVWAydUff3XeTjHjC2IWwqdJT.zFckdjBhjgtpWnF86jKJEslwNNDh(Uey87mYmw.zWgRAVWAydUff3XeTjHjC2IWwqdJT.zFckdjBhjgtpWnF86jKJEslwNNDh(Uey87mYmw.zWS8KzgI.zQMvNzDHSaeMIDLJ7gxz5T4pkmgWk(), Uey87mYmw.zWgRAVWAydUff3XeTjHjC2IWwqdJT.zF258t9YWmsl_njRV3Z8vJPbe78_(Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw.zuW2VD6s)), Uey87mYmw.zQUrYtJA.zQMvNzDHSaeMIDLJ7gxz5T4pkmgWk())), Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw.zOsDyjc)));
                }
            }
            private sealed class zvCdVC1k
            {
                [MethodImpl(MethodImplOptions.NoInlining)]
                public static int zQMvNzDHSaeMIDLJ7gxz5T4pkmgWk()
                {
                    return Uey87mYmw.zWgRAVWAydUff3XeTjHjC2IWwqdJT.zQk9sG6NtHfZfL4NJr_dHtgLAb2hc(Uey87mYmw.zWgRAVWAydUff3XeTjHjC2IWwqdJT.zFckdjBhjgtpWnF86jKJEslwNNDh(Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw.zQUrYtJA)), Uey87mYmw.zWgRAVWAydUff3XeTjHjC2IWwqdJT.zQk9sG6NtHfZfL4NJr_dHtgLAb2hc(Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw.zvCdVC1k)), Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw.zuW2VD6s)))), Uey87mYmw.zOsDyjc.zQMvNzDHSaeMIDLJ7gxz5T4pkmgWk());
                }
            }
            private static int zpA4ZyzlhsJGgQ_Gu731pql5_qaB(Type zUP32avhLniz6yQWN3uuytgBAxyV5)
            {
                return zUP32avhLniz6yQWN3uuytgBAxyV5.MetadataToken;
            }
            private sealed class zIoPVO2k_lPS0VepLdhHy9J8U0PCh
            {
                [MethodImpl(MethodImplOptions.NoInlining)]
                public long zL17hQNDWdLnZfxSKw0AKFhwoInV()
                {
                    if (Assembly.GetCallingAssembly() != typeof(Uey87mYmw.zIoPVO2k_lPS0VepLdhHy9J8U0PCh).Assembly)
                    {
                        return 2918384L;
                    }
                    if (!Uey87mYmw.zEgkzkI5uDHmjgdQQ5hCp6A2gV98())
                    {
                        return 2918384L;
                    }
                    int[] array = new int[]
                    {
                0,
                0,
                0,
                -(~(-(~(-(~(~(-(~1413655109))))))))
                    };
                    array[1] = -(~(-(~(~(-(-(~(~(-(~-1060173103))))))))));
                    array[2] = -(~(-(~(-(~(~(-(~822493547))))))));
                    array[0] = ~(-(-(~(~(-(~(-(~-894507357))))))));
                    int num = this.ztcyA3dARRafZG8KQAhCiM;
                    int num2 = this.z0dX2t_Z_Q7j1HpNMXErz24AGa8Oy;
                    int num3 = -(~(-(~(-(~(~(-(~1640531528))))))));
                    int num4 = -(~(-(~(-(~(~(-(~957401313))))))));
                    for (int num5 = 0; num5 != 32; num5++)
                    {
                        num2 -= ((num << 4 ^ num >> 5) + num ^ num4 + array[num4 >> 11 & 3]);
                        num4 -= num3;
                        num -= ((num2 << 4 ^ num2 >> 5) + num2 ^ num4 + array[num4 & 3]);
                    }
                    for (int num6 = 0; num6 != 4; num6++)
                    {
                        array[num6] = 0;
                    }
                    ulong num7 = (ulong)((ulong)((long)num2) << 32);
                    return (long)(num7 | (ulong)num);
                }
                public zIoPVO2k_lPS0VepLdhHy9J8U0PCh()
                {
                    this.zeet1Gc3RDwVPl3_vEPpwOUMuYRc(0L);
                }
                [MethodImpl(MethodImplOptions.NoInlining)]
                public void zeet1Gc3RDwVPl3_vEPpwOUMuYRc(long zJRJI60MxF_uBBBZsCaSnBfk)
                {
                    if (Assembly.GetCallingAssembly() != typeof(Uey87mYmw.zIoPVO2k_lPS0VepLdhHy9J8U0PCh).Assembly)
                    {
                        return;
                    }
                    if (!Uey87mYmw.zEgkzkI5uDHmjgdQQ5hCp6A2gV98())
                    {
                        return;
                    }
                    int[] array = new int[4];
                    array[1] = -(~(~(-(~(-(-(~(-(~(~-1060173103))))))))));
                    array[0] = ~(-(-(~(~(-(-(~(~(-(~-894507356))))))))));
                    array[2] = -(~(-(~(~(-(-(~(-(~(~822493548))))))))));
                    array[3] = ~(-(-(~(-(~(~(-(-(~(~1413655108))))))))));
                    int num = -(~(~(-(-(~(-(~(~1640531528))))))));
                    int num2 = (int)zJRJI60MxF_uBBBZsCaSnBfk;
                    int num3 = (int)(zJRJI60MxF_uBBBZsCaSnBfk >> 32);
                    int num4 = 0;
                    for (int num5 = 0; num5 != 32; num5++)
                    {
                        num2 += ((num3 << 4 ^ num3 >> 5) + num3 ^ num4 + array[num4 & 3]);
                        num4 += num;
                        num3 += ((num2 << 4 ^ num2 >> 5) + num2 ^ num4 + array[num4 >> 11 & 3]);
                    }
                    for (int num6 = 0; num6 != 4; num6++)
                    {
                        array[num6] = 0;
                    }
                    this.ztcyA3dARRafZG8KQAhCiM = num2;
                    this.z0dX2t_Z_Q7j1HpNMXErz24AGa8Oy = num3;
                }
                private int ztcyA3dARRafZG8KQAhCiM;
                private int z0dX2t_Z_Q7j1HpNMXErz24AGa8Oy;
            }
            private static Uey87mYmw.zIoPVO2k_lPS0VepLdhHy9J8U0PCh zn1hqUaiUE7TgzppFP5OIl0_vKHo1 = new Uey87mYmw.zIoPVO2k_lPS0VepLdhHy9J8U0PCh();
            [MethodImpl(MethodImplOptions.NoInlining)]
            private static bool zEgkzkI5uDHmjgdQQ5hCp6A2gV98()
            {
                return Uey87mYmw.zAUuvpg84a1Yl2LlaIQ7FY0Brwxcl();
            }
            [MethodImpl(MethodImplOptions.NoInlining)]
            private static bool zAUuvpg84a1Yl2LlaIQ7FY0Brwxcl()
            {
                StackTrace stackTrace = new StackTrace();
                StackFrame frame = stackTrace.GetFrame(3);
                MethodBase methodBase = (frame == null) ? null : frame.GetMethod();
                Type type = (methodBase == null) ? null : methodBase.DeclaringType;
                return type != typeof(RuntimeMethodHandle) && type != null && type.Assembly == typeof(Uey87mYmw).Assembly;
            }
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static long z2uo70I4()
            {
                if (Assembly.GetCallingAssembly() != typeof(Uey87mYmw).Assembly || !Uey87mYmw.zEgkzkI5uDHmjgdQQ5hCp6A2gV98())
                {
                    return 0L;
                }
                long result;
                lock (Uey87mYmw.zn1hqUaiUE7TgzppFP5OIl0_vKHo1)
                {
                    long num = Uey87mYmw.zn1hqUaiUE7TgzppFP5OIl0_vKHo1.zL17hQNDWdLnZfxSKw0AKFhwoInV();
                    if (num == 0L)
                    {
                        Assembly executingAssembly = Assembly.GetExecutingAssembly();
                        List<byte> list = new List<byte>();
                        AssemblyName assemblyName;
                        try
                        {
                            assemblyName = executingAssembly.GetName();
                        }
                        catch
                        {
                            assemblyName = new AssemblyName(executingAssembly.FullName);
                        }
                        byte[] array = assemblyName.GetPublicKeyToken();
                        if (array != null && array.Length == 0)
                        {
                            array = null;
                        }
                        if (array != null)
                        {
                            list.AddRange(array);
                        }
                        list.AddRange(Encoding.Unicode.GetBytes(assemblyName.Name));
                        int num2 = Uey87mYmw.zpA4ZyzlhsJGgQ_Gu731pql5_qaB(typeof(Uey87mYmw));
                        int num3 = Uey87mYmw.zvCdVC1k.zQMvNzDHSaeMIDLJ7gxz5T4pkmgWk();
                        list.Add((byte)(num2 >> 24));
                        list.Add((byte)(num3 >> 8));
                        list.Add((byte)num2);
                        list.Add((byte)(num3 >> 24));
                        list.Add((byte)(num2 >> 8));
                        list.Add((byte)num3);
                        list.Add((byte)(num2 >> 16));
                        list.Add((byte)(num3 >> 16));
                        int count = list.Count;
                        ulong num4 = 0UL;
                        for (int num5 = 0; num5 != count; num5++)
                        {
                            num4 += (ulong)list[num5];
                            num4 += num4 << 20;
                            num4 ^= num4 >> 12;
                            list[num5] = 0;
                        }
                        num4 += num4 << 6;
                        num4 ^= num4 >> 22;
                        num4 += num4 << 30;
                        num = (long)num4;
                        num ^= 8166198817072804713L;
                        Uey87mYmw.zn1hqUaiUE7TgzppFP5OIl0_vKHo1.zeet1Gc3RDwVPl3_vEPpwOUMuYRc(num);
                    }
                    result = num;
                }
                return result;
            }
        }
        public interface BY4t_7dL4c<zlAP7WS4> : qGl_mYggBAzULUn7Sy5i31vKljnaJeBbDZ5Dxt8VPh0
        {
            Yfzf1k<zlAP7WS4> GetEnumerator();
        }
        public interface qGl_mYggBAzULUn7Sy5i31vKljnaJeBbDZ5Dxt8VPh0
        {
            qQIm9LoCGeisrs2N6gx6vsbcKJileQc6lC4jzqWytze4 zRl6Lfh3H_A7CGhLIjgvxCNJ8OKbNAlibMlhWr8UyzW0syCosfDlPDRUtn8avzvk0ouOCUqgrfGQn2siA();
        }
        public static class DnS90
        {
            public sealed class zlAP7WS4 : BY4t_7dL4c<int>, Yfzf1k<int>, qQIm9LoCGeisrs2N6gx6vsbcKJileQc6lC4jzqWytze4, qmX5GgA7KxW7z_9hiz1UGf5dCa9fpYN5dk0i2NBjWdOE
            {
                private int zlAP7WS4_int;
                private int z94efOzc;
                public int za864OmQ;
                private int zuhFL5Zs;
                private int zsXgJLo;
                [DebuggerHidden]
                public zlAP7WS4(int zlAP7WS4)
                {
                    this.zlAP7WS4_int = zlAP7WS4;
                    this.z94efOzc = Thread.CurrentThread.ManagedThreadId;
                }

                public Yfzf1k<int> GetEnumerator()
                {
                    DnS90.zlAP7WS4 zlAP7WS4;
                    if (this.zlAP7WS4_int == -2 && this.z94efOzc == Thread.CurrentThread.ManagedThreadId)
                    {
                        this.zlAP7WS4_int = 0;
                        zlAP7WS4 = this;
                    }
                    else
                    {
                        zlAP7WS4 = new DnS90.zlAP7WS4(0);
                    }
                    zlAP7WS4.zuhFL5Zs = this.za864OmQ;
                    return zlAP7WS4;
                }

                qQIm9LoCGeisrs2N6gx6vsbcKJileQc6lC4jzqWytze4 qGl_mYggBAzULUn7Sy5i31vKljnaJeBbDZ5Dxt8VPh0.zRl6Lfh3H_A7CGhLIjgvxCNJ8OKbNAlibMlhWr8UyzW0syCosfDlPDRUtn8avzvk0ouOCUqgrfGQn2siA()
                {
                    DnS90.zlAP7WS4 zlAP7WS4;
                    if (this.zlAP7WS4_int == -2 && this.z94efOzc == Thread.CurrentThread.ManagedThreadId)
                    {
                        this.zlAP7WS4_int = 0;
                        zlAP7WS4 = this;
                    }
                    else
                    {
                        zlAP7WS4 = new DnS90.zlAP7WS4(0);
                    }
                    zlAP7WS4.zuhFL5Zs = this.za864OmQ;
                    return zlAP7WS4;
                }

                int Yfzf1k<int>.zdclzXzxb1ekfNClJKzTiCVS2izYAXQ5uIydZWmgxBeSHpipkobt8A0kgoDadRtQTjfh5lcuE5xdQEzw()
                {
                    return this.zsXgJLo;
                }

                bool qQIm9LoCGeisrs2N6gx6vsbcKJileQc6lC4jzqWytze4.zjvUHwnVuaKKBRLGPYUVNc0xlD7U6a9TQyo6pdQMe4nSP_KlWgLc61H3KLE9RWCtgHSF4wI()
                {
                    switch (this.zlAP7WS4_int)
                    {
                        case 0:
                            this.zlAP7WS4_int = -1;
                            this.zsXgJLo = -231915788;
                            this.zlAP7WS4_int = 1;
                            return true;
                        case 1:
                            this.zlAP7WS4_int = -1;
                            this.zsXgJLo = (this.zuhFL5Zs ^ -74861478);
                            this.zlAP7WS4_int = 2;
                            return true;
                        case 2:
                            this.zlAP7WS4_int = -1;
                            this.zsXgJLo = -114657473;
                            this.zlAP7WS4_int = 3;
                            return true;
                        case 3:
                            this.zlAP7WS4_int = -1;
                            this.zsXgJLo = (this.zuhFL5Zs ^ -74861478);
                            this.zlAP7WS4_int = 4;
                            return true;
                        case 4:
                            this.zlAP7WS4_int = -1;
                            this.zsXgJLo = -1951694008;
                            this.zlAP7WS4_int = 5;
                            return true;
                        case 5:
                            this.zlAP7WS4_int = -1;
                            this.zsXgJLo = (this.zuhFL5Zs ^ -503468845);
                            this.zlAP7WS4_int = 6;
                            return true;
                        case 6:
                            this.zlAP7WS4_int = -1;
                            this.zsXgJLo = -1677850036;
                            this.zlAP7WS4_int = 7;
                            return true;
                        case 7:
                            this.zlAP7WS4_int = -1;
                            this.zsXgJLo = 1186527170;
                            this.zlAP7WS4_int = 8;
                            return true;
                        case 8:
                            this.zlAP7WS4_int = -1;
                            return false;
                        default:
                            return false;
                    }
                }

                object qQIm9LoCGeisrs2N6gx6vsbcKJileQc6lC4jzqWytze4.zdclzXzxb1ekfNClJKzTiCVS2izYAXQ5uIydZWmgxBeSHpipkobt8A0kgoDadRtQTjfh5lcuE5xdQEzw()
                {
                    return this.zsXgJLo;
                }

                void qQIm9LoCGeisrs2N6gx6vsbcKJileQc6lC4jzqWytze4.zj6fo_ej1NsFwWiAaGRGlkVfRI6e3BTRz9dJQW0kXJQ_eVc32yIKGEeFEefxaTFH4TcjDhoVYuJmc7VxrzUYjbEw()
                {
                    throw new NotImplementedException();
                }

                void qmX5GgA7KxW7z_9hiz1UGf5dCa9fpYN5dk0i2NBjWdOE.zcBVCa88Tj1Bl8OoRPzs3_BLpDGcsUnbF0pqVOYfpdCLKQK1FYQoMQIwPQ58dQoxHJ7Xl02XgjhnBoCykQ()
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}