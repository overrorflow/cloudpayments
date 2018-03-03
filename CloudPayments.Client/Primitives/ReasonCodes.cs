// Copyright (c) 2017 Samburov Konstantin <samburovkv@yandex.ru>.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
namespace CloudPayments.Client
{
    public enum ReasonCodes
    {
        Approved = 0,
        ReferToCardIssuer = 5001,
        PickUpCard = 5004,
        DoNotHonor = 5005,
        Error = 5006,
        InvalidTransaction = 5012,
        AmountError = 5013,
        FormatError = 5030,
        BankNotSupportedBySwitch = 5031,
        SuspectedFraud = 5034,
        LostCard = 5041,
        StolenCard = 5043,
        InsufficientFunds = 5051,
        ExpiredCard = 5054,
        TransactionNotPermitted = 5057,
        ExceedWithdrawalFrequency = 5065,
        IncorrectCVV = 5082,
        Timeout = 5091,
        CannotReachNetwork = 5092,
        SystemError = 5096,
        UnableToProcess = 5204,
        AuthenticationFailed = 5206,
        AuthenticationUnavailable = 5207,
        AntiFraud = 5300
    }
}
