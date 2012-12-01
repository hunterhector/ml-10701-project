Following Pang et al.(2002), we use unigram-presence features: the ith coordinate of a feature vector is 1 if the corresponding unigram occurs in the input text, 0 otherwise.
W02-1011
However, modeling proximity relationships between sentences would enable us to leverage coherence: text spans occurring near each other (within discourse boundaries) may share the same subjectivity status, other things being equal (Wiebe, 1994).
J94-2004
Riloff and Wiebe (2003) state that “It is [very hard] to obtain collections of individual sentences that can be easily identified as subjective or objective”; the polarity-dataset sentences, for example, have not 4Available at www.cs.cornell.edu/people/pabo/moviereview-data/ (review corpus version 2.0). been so annotated.5 Fortunately, we were able to mine the Web to create a large, automaticallylabeled sentence corpus6.
W03-0404 W03-1014
Second, movie reviews are apparently harder to classify than reviews of other products (Turney, 2002; Dave, Lawrence, and Pennock, 2003).
P02-1053
Interestingly, Yu and Hatzivassiloglou (2003) compared an individual-preference classifier against a relationship-based method, but didn’t combine the two; the ability to coordinate such algorithms is precisely one of the strengths of our approach.
W03-1017
Document polarity classification poses a significant challenge to data-driven methods, resisting traditional text-categorization techniques (Pang, Lee, and Vaithyanathan, 2002).
W02-1011
Hence, standard machinelearning classification techniques, such as support vector machines (SVMs), can be applied to the entire documents themselves, as was done by Pang, Lee, and Vaithyanathan (2002).
W02-1011
Yu and Hatzivassiloglou (2003) provide methods for sentencelevel analysis and for determining whether a document is subjective or not, but do not combine these two types of algorithms or consider document polarity classification.
W03-1017
But a crucial advantage specific to the utilization of a minimum-cut-based approach is that we can use maximum-flow algorithms with polynomial asymptotic running times — and near-linear running times in practice — to exactly compute the minimumcost cut(s), despite the apparent intractability of the optimization problem (Cormen, Leiserson, and Rivest, 1990; Ahuja, Magnanti, and Orlin, 1993).2 In contrast, other graph-partitioning problems that have been previously used to formulate NLP classification problems3 are NP-complete (Hatzivassiloglou and McKeown, 1997; Agrawal et al., 2003; Joachims, 2003).
P97-1023
