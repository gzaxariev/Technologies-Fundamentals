import java.util.Scanner;

public class p14FitStringIn20Chars {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String text = scanner.nextLine();

        if (text.length()>=20){

            char [] newText = text.toCharArray();

            for (int i = 0; i <20 ; i++) {

                System.out.print(newText[i]);

            }

        }else {
            System.out.print(text);
            for (int i = text.length(); i <20; i++) {
                System.out.print("*");
            }
        }

    }
}
