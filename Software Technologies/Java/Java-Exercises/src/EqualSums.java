import java.util.Arrays;
import java.util.Scanner;

public class p11EqualSums {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int [] nums =Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();


        for (int i = 0; i <nums.length ; i++) {

            int leftSum = Arrays.stream(nums).limit(i).sum();

            int rightSum = Arrays.stream(nums).skip(i +1).sum();

            if (leftSum == rightSum){
                System.out.println(i);
                return;
            }

        }
        System.out.println("no");
    }
}
