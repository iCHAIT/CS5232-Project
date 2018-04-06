import numpy as np

# Uncomment line fow which you want prob matrix
# fname = "/Users/chaitanyagupta/Desktop/CS5232-Project/Twitter/final_order_twitter.txt"
# fname = "/Users/chaitanyagupta/Desktop/CS5232-Project/Facebook/final_order_fb.txt"
fname = "/Users/chaitanyagupta/Desktop/CS5232-Project/Dropbox/final_order_dropbox.txt"


with open(fname) as f:
    order = f.read().splitlines()

list = order[:]

matrix = np.zeros(shape=(8, 8))

mapping = {'X': 0, 'A': 1, 'B': 2, 'C': 3, 'D': 4,
           'E': 5, 'F': 6, 'Y': 7}


def matrix_update(start, end, mat):
    mat[mapping[start], mapping[end]] += 1
    return mat


for i in range(len(order) - 1):
    matrix = matrix_update(list[i], list[i + 1], matrix)


print(matrix)
print(matrix / matrix.sum())
