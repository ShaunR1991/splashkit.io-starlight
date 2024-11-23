from splashkit import *

# Define the first vector
my_vector_1 = Vector2D()
my_vector_1.x = 200
my_vector_1.y = 100

# Define the second vector
my_vector_2 = Vector2D()
my_vector_2.x = -300
my_vector_2.y = 150

# Define the third vector
my_vector_3 = Vector2D()
my_vector_3.x = 200
my_vector_3.y = 100

# Print the vectors
write_line("Vector 1: " + vector_to_string(my_vector_1))
write_line("Vector 2: " + vector_to_string(my_vector_2))
write_line("Vector 3: " + vector_to_string(my_vector_3))

# Check if vectors are not equal
if vectors_not_equal(my_vector_1, my_vector_2):
    write_line("Vectors 1 and 2 are not equal.")
else:
    write_line("Vectors 1 and 2 are equal.")

if vectors_not_equal(my_vector_1, my_vector_3):
    write_line("Vectors 1 and 3 are not equal.")
else:
    write_line("Vectors 1 and 3 are equal.")

if vectors_not_equal(my_vector_2, my_vector_3):
    write_line("Vectors 2 and 3 are not equal.")
else:
    write_line("Vectors 2 and 3 are equal.")
