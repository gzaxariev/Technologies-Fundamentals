import java.util.Arrays;
import java.util.Scanner;

public class p09MosFrequentNumber {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] nums = Arrays.stream(scanner.nextLine()
                .split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        int maxCounter = 0;
        int maxNumber = nums[0];


        for (int i = 0; i < nums.length; i++) {
            int tempCounter = 0;
            for (int j = 0; j < nums.length; j++) {

                if (nums[i] == nums[j]) {
                    tempCounter++;
                }

            }

            if (tempCounter > maxCounter) {
                maxCounter = tempCounter;

                maxNumber = nums[i];
            }

        }
        System.out.println(maxNumber);

    }
}
