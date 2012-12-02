with Giza We evaluated our discriminative approach by comparing it with the state-of-art Giza++ alignments (Och and Ney, 2003).
J03-1002
We use an online learning framework called MIRA (McDonald et al., 2005; Crammer and Singer, 2003) for training a discriminative model for the word alignment task (Taskar et al., 2005; Moore, 2005).
H05-1010 H05-1011 H05-1066
State-of-art systems for doing word alignment use generative models like GIZA++ (Och and Ney, 2003; Brown et al., 1993).
J03-1002 J93-2003
We use an online large margin approach called MIRA (McDonald et al., 26 2005; Crammer and Singer, 2003) which fits well with our framework.
H05-1066
Discriminative models have been tried recently for word-alignment (Taskar et al., 2005; Moore, 2005) as these models give the ability to harness variety of complex features which cannot be provided in the generative models.
H05-1010 H05-1011
For training our model, use used an online large margin algorithm (McDonald et al., 2005).
H05-1066
The alignment error rate which we achieve (AER = 0.5040) is significantly better (about 10% decrease in AER) than the alignment error rates of the state-of-art models (Och and Ney, 2003) (Best AER = 0.5518) on the English-Hindi dataset.
J03-1002
For parameter optimization for the wordalignment task, Taskar, Simon and Klein (Taskar et al., 2005) used a large margin approach by factoring the structure level constraints to constraints at the level of an alignment link.
H05-1010
MIRA has previously been used by McDonald, Pereira, Ribarov and Hajic (McDonald et al., 2005) for learning the parameter values in the task of dependency parsing.
H05-1066
It should be noted that previous word-alignment experiments such as Taskar, Simon and Klein (Taskar et al., 2005) have been done with very large datasets and there is little word-order variation in the languages involved.
H05-1010
Moore. 2005.
H05-1011
Some of them are Frequency, Point-wise mutual information (Church and Hanks, 1989), Distributed frequency of object (Tapanainen et al., 1998), Distributed frequency of object using verb information (Venkatapathy and Joshi, 2005), Similarity of object in verbobject pair using the LSA model (Baldwin et al., 2003), (Venkatapathy and Joshi, 2005) and Lexical and Syntactic fixedness (Fazly and Stevenson, 2006).
E06-1043 H05-1113 P89-1010 P98-2210 W03-1812
He/N away/RP ran/V vaha bhaaga gayaa MI = HIGH Figure 6: Example of MergeMI feature 6 Online large margin training For parameter optimization, we have used an online large margin algorithm called MIRA (McDonald et al., 2005) (Crammer and Singer, 2003).
H05-1066
Some of these are mutual information (Church and Hanks, 1989), distributed frequency (Tapanainen et al., 1998) and Latent Semantic Analysis (LSA) model (Baldwin et al., 2003).
P89-1010 P98-2210 W03-1812
Our overall results are better than those obtained using the GIZA++ models (Och and Ney, 2003).
J03-1002
