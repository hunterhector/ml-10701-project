In addition, we developed a word clustering procedure (based on a standard approach (Brown et al., 1992)) that optimizes conditional word clusters.
J92-4003
More recently, a method for clustering words at different positions was developed (Yamamoto et al., 2001; Gao et al., 2002).
P01-1068 P02-1024
We score using the model P(wtjwt 1;wt 2;at).1 Different back-off strategies, including different back-off paths as well as combination methods (Bilmes and Kirchhoff, 2003), were tried and here we present the best results.
N03-2002
SRILM (Stolcke, 2002) can produce classes to maximize the mutual information between the classes I(C(wt);C(wt 1)), as described in (Brown et al., 1992).
J92-4003
Table 2: Three types of class-based MSLMs on Switchboard-I (swbd) and ICSI Meeting (mr) corpora # of swbd mr classes BROWN MMI MCMI BROWN MMI MCMI 100 68.9 0.3 68.4 0.3 68.2 0.3 78.9 3.0 77.3 2.8 76.8 2.8 500 68.9 0.3 68.3 0.3 67.9 0.3 78.7 3.1 77.1 2.8 76.7 2.8 1000 68.9 0.3 68.2 0.3 67.9 0.3 79.0 3.1 77.2 2.7 76.9 2.8 1500 69.0 0.3 68.2 0.3 68.0 0.3 79.6 3.1 77.4 2.7 77.4 2.7 2000 69.0 0.3 68.3 0.3 68.0 0.3 80.1 3.1 77.6 2.7 77.9 2.7 jV j 68.5 0.3 78.3 2.7 Table 3: Class-based MSLM on Switchboard Eval-2003 size 100 500 1000 1500 2000 jV j 3-gram 4-gram ppl 65.8 65.5 65.6 65.7 66.1 67.9 72.1 76.3 % reduction 8.6 8.9 8.8 8.7 8.3 5.8 0 -5.8 Class-based language models (Brown et al., 1992; Whittaker and Woodland, 2003) yield great bene ts when data sparseness abounds.
J92-4003
A re nement of this model is the class-based n-gram where the words are partitioned into equivalence classes (Brown et al., 1992).
J92-4003
We compare an optimized four-gram, a threegram baseline, and various numbers of cluster sizes using our MCMI method and generalized backoff (Bilmes and Kirchhoff, 2003), which, (again) with 500 clusters, achieves an 8.9% relative improvement over the trigram.
N03-2002
Such a model is easily represented using a factored language model (FLM), an idea introduced in (Bilmes and Kirchhoff, 2003; Kirchhoff et al., 2003), and incorporated into the SRILM toolkit (Stolcke, 2002).
N03-2002
To compare different clustering algorithms, results with the standard method of (Brown et al., 1992) (SRILM’s ngram-class) are also reported.
J92-4003
