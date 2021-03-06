namespace GWallet.Backend

open System

type TransferAmount(valueToSend: decimal, balanceAtTheMomentOfSending: decimal, currency: Currency) =
    do
        if valueToSend <= 0m then
            invalidArg "valueToSend" "Amount has to be above zero"
        if balanceAtTheMomentOfSending < valueToSend then
            invalidArg "balanceAtTheMomentOfSending" "balance has to be equal or higher than valueToSend"

    member __.ValueToSend
        with get() = Math.Round(valueToSend, currency.DecimalPlaces())

    member __.BalanceAtTheMomentOfSending
        with get() = balanceAtTheMomentOfSending

    member __.Currency
        with get() = currency

