#include "splashkit.h"

int main()
{
    // Define the first vector
    vector_2d my_vector_1;
    my_vector_1.x = 200;
    my_vector_1.y = 100;

    // Define the second vector (zero vector)
    vector_2d my_vector_2;
    my_vector_2.x = 0;
    my_vector_2.y = 0;

    // Check if the vectors are zero vectors
    bool check_zero_1 = is_zero_vector(my_vector_1);
    bool check_zero_2 = is_zero_vector(my_vector_2);

    // Output the results
    write_line(check_zero_1);
    write_line(check_zero_2);

    return 0;
}
