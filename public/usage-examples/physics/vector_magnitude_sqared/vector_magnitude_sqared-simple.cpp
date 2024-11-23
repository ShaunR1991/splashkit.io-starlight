#include "splashkit.h"

using std::to_string;

int main()
{
    // Define a vector
    vector_2d my_vector_1;
    my_vector_1.x = 200;
    my_vector_1.y = 100;

    // Calculate the squared magnitude of the vector
    double my_vector_1_magnitude_squared = vector_magnitude_sqared(my_vector_1);

    // Output the vector and its squared magnitude
    write_line(vector_to_string(my_vector_1));
    write_line("Vector Magnitude Squared: " + to_string(my_vector_1_magnitude_squared));

    return 0;
}
