using dotnet_technical_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_technical_test.Controllers.Utility
{
    /// <summary>
    /// This class was necessary to be created because ExchangeRate API
    /// would not allow pair currency requests. Therefore, all their
    /// available currencies have been aggregated in this helper class.
    /// This would not be necessary with a premium account.
    /// </summary>
    public static class ExchangeUtility
    {
        /// <summary>
        /// Converts the user selected currency and amount into
        /// the desired currency, based on the latest exchange
        /// rate snapshot.
        public static double Convert(Currency currency, ExchangeResult result)
        {
            switch (currency.TargetCurrency)
            {
                case "AED":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.AED);
                case "ARS":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.ARS);
                case "AUD":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.AUD);
                case "BGN":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.BGN);
                case "BRL":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.BRL);
                case "BSD":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.BSD);
                case "CAD":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.CAD);
                case "CHF":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.CHF);
                case "CLP":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.CLP);
                case "CNY":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.CNY);
                case "COP":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.COP);
                case "CZK":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.CZK);
                case "DKK":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.DKK);
                case "DOP":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.DOP);
                case "EGP":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.EGP);
                case "EUR":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.EUR);
                case "FJD":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.FJD);
                case "GBP":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.GBP);
                case "GTQ":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.GTQ);
                case "HKD":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.HKD);
                case "HRK":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.HRK);
                case "HUF":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.HUF);
                case "IDR":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.IDR);
                case "ILS":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.ILS);
                case "INR":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.INR);
                case "ISK":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.ISK);
                case "JPY":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.JPY);
                case "KRW":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.KRW);
                case "KZT":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.KZT);
                case "MXN":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.MXN);
                case "MYR":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.MYR);
                case "NOK":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.NOK);
                case "NZD":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.NZD);
                case "PAB":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.PAB);
                case "PEN":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.PEN);
                case "PHP":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.PHP);
                case "PKR":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.PKR);
                case "PLN":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.PLN);
                case "PYG":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.PYG);
                case "RON":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.RON);
                case "RUB":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.RUB);
                case "SAR":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.SAR);
                case "SEK":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.SEK);
                case "SGD":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.SGD);
                case "THB":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.THB);
                case "TRY":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.TRY);
                case "TWD":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.TWD);
                case "UAH":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.UAH);
                case "USD":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.USD);
                case "UYU":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.UYU);
                case "ZAR":
                    return GetExchangeResult(currency.SourceAmount, result.conversion_rates.ZAR);
                default:
                    return 0.0;
            }
        }

        private static double GetExchangeResult(double x, double y)
        {
            return x * y;
        }
    }
}
