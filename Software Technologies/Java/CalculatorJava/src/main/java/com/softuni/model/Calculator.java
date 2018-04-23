package com.softuni.model;

public class Calculator {

    public double leftOperand;
    public  double rightOperand;
    public String operator;

    public Calculator(double leftOperand, double rightOperand, String operator) {
        this.leftOperand = leftOperand;
        this.rightOperand = rightOperand;
        this.operator = operator;
    }

    public double getLeftOperand() {
        return this.leftOperand;
    }

    public double getRightOperand() {
        return this.rightOperand;
    }

    public String getOperator() {
        return this.operator;
    }

    public double CalculateResult() {

        double result;

        switch (this.operator){
            case "+":
               result =  this.leftOperand + this.rightOperand;
                       break;
            case "-":
                result = this.leftOperand - this.rightOperand;
                        break;
            case "*":
                result =  this.leftOperand * this.rightOperand;
                break;
            case "/":
                result = this.leftOperand / this.rightOperand;
                break;
                default:
                    result = 0.0;
                    break;


        }
        return result;

    }
}
