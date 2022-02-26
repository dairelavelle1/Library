using System;

public interface ITarget {
    // The Target defines the domain-specific interface used by the client code.
    public string getCreditCardNo();
    public string getCustomerName();
    public string getCardExpMonth();
    public string getCardExpYear();
    public string getCardCVV();
    public double getAmount();

    public void setCreditCardNo(string creditCardNo);
    public void setCustomerName(string customerName);
    public void setCardExpMonth(string cardExpMonth);
    public void setCardExpYear(string cardExpYear);
    public void setCardCVV(string cardCVV);
    public void setAmount(double amount);


}