import java.util.Scanner;

public class p10IndexOfLetters {
    public static void main(String[] args) {
        Scanner scanner  = new Scanner(System.in);

        String text = scanner.nextLine();

        for (int i = 0; i <text.length() ; i++) {

            for (int j = 'a'; j <= 'z'; j++) {

                if(text.charAt(i)==j){
                    System.out.println(text.charAt(i)+ " -> " +(text.charAt(i)-97) );
                }

            }

        }
    }
}
