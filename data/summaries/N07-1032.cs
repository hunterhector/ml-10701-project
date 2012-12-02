To the best of our knowledge, this cross-instance learning problem has only been tackled in (Eisner and Karakos, 2005), whose “strapping” procedure learns a meta-classifier for distinguishing good from bad clusterings.
H05-1050
A variety of algorithms (e.g., bootstrapping (Yarowsky, 1995), co-training (Blum and Mitchell, 1998), alternating structure optimization (Ando and Zhang, 2005), etc).
P95-1026
One option is to perform a tuning that directly minimizes the error on the supervised data sets; another option is to use “strapping” (Eisner and Karakos, 2005), which builds a classifier that learns to distinguish good from bad clusterings, and then selects the α with the best predicted clustering on the test set.
H05-1050
(In the original strapping paper, for example, Eisner and Karakos (2005) generated their collection by bootstrapping word-sense classifiers from 200 different seeds.) Here is how we choose a particular unsupervised α-clustering to output for a given test collection: • We cluster the test collection (e.g., the first Multi5 collection) with various values of α, namely α = 0.1,0.2,...,1.0.
H05-1050
α with “Strapping” In order to pick the value of the parameter α for each of the sIB and IDT test experiments, we use “strapping” (Eisner and Karakos, 2005), which, as we mentioned earlier, is a technique for training a meta-classifier that chooses among possible clusterings.
H05-1050
