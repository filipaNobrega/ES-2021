using System;

namespace CurrencyCalculator.LastVersion
{
    public class CurrencyValue : ISubject
    {
        private double _value = 0;

        public double this[CurrencyType currencyType]
        {
            get
            {
                switch (currencyType)
                {
                    case CurrencyType.Euros:
                        return _value;
                    case CurrencyType.Dollars:
                        return _value * 1.4774;
                    case CurrencyType.Pounds:
                        return _value * 0.9068811;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(currencyType), currencyType, null);
                }
            }
            set
            {
                switch (currencyType)
                {
                    case CurrencyType.Euros:
                        _value = value;
                        break;
                    case CurrencyType.Dollars:
                        _value = value * 0.676864762;
                        break;
                    case CurrencyType.Pounds:
                        _value = value * 1.102680380;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(currencyType), currencyType, null);
                }
                Notify( currencyType );
            }
        }

        private readonly Subject _subject = new Subject();

        public event UpdateEventHandler OnUpdate
        {
            add => _subject.OnUpdate += value;
            remove => _subject.OnUpdate -= value;
        }

        public void Notify(object data)
        {
            _subject.Notify(this, data);
        }
    }
}