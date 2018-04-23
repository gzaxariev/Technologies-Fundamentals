import java.util.Scanner;

public class p06CompareCharArrays {


    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        char[] first = scanner.nextLine().toCharArray();

        char[] second = scanner.nextLine().toCharArray();

        int endIndex = Math.min(first.length, second.length);

        for (int i = 0; i < endIndex; i++) {

            if (first[i] == ' ') {
                continue;
            }
            if (first[i] > second[i]) {
                printCharArray(second);
                printCharArray(first);
                System.out.println();
                break;
            } else if (second[i] > first[i]) {
                printCharArray(first);
                printCharArray(second);
                break;
            } else if (i == endIndex - 1) {
                if (first.length > second.length) {
                    printCharArray(second);
                    printCharArray(first);
                } else {
                    printCharArray(first);
                    printCharArray(second);
                }
            }

        }


    }

    private static void printCharArray(char[] arr) {
        for (char ch : arr) {
            if (ch != ' ') {
                System.out.printf("%c", ch);
            }
        }
        System.out.println();

    }
}
