Therefore, variables used in Hidden Markov models of pitch accent prediction have been very limited, e.g. part of speech and frequency (Pan and McKeown, 1999).
W99-0619
However, gradient-based methods have often found to be more efficient for minimizing Equation 3 (Minka, 2001; Sha and Pereira, 2003).
N03-1028
One exception to this line of research is the use of Hidden Markov Models (HMM) for pitch accent prediction (Pan and McKeown, 1999; Conkie et al., 1999).
W99-0619
Note that Pan and McKeown (1999) reported 74% accuracy with their HMM model.
W99-0619
variables Following a line of research that incorporates the information content of a word as well as collocation measures (Pan and McKeown, 1999; Pan and Hirschberg, 2001) we have included a number of probabilistic variables.
W99-0619
Various measures of a word’s informativeness, such as the information content (IC) of a word (Pan and McKeown, 1999) and its collocational strength in a given context (Pan and Hirschberg, 2001) have also proven to be useful models of pitch accent.
W99-0619
To overcome this problem, we penalize the objective function by adding a Gaussian prior (a term proportional to the squared norm jj jj2) as suggested in (Johnson et al., 1999).
P99-1069
Pan and McKeown (1999) demonstrate the effectiveness of a sequence model over a rule induction system, RIPPER, that treats each label independently by showing that HMMs outperform RIPPER when the same variables are used.
W99-0619
Different machine learning techniques, such as decision trees (Hirschberg, 1993), rule induction systems (Pan and McKeown, 1999), bagging (Sun, 2002), boosting (Sun, 2002) have been used in a scenario where the accent of each word is predicted independently.
W99-0619
We did not test directly the probabilistic measures (or collocation measures) that have been used before for this task, namely information content (IC) (Pan and McKeown, 1999) and mutual information (Pan and Hirschberg, 2001).
W99-0619
Discriminative learning methods, such as Maximum Entropy Markov Models (McCallum et al., 2000), Projection Based Markov Models (Punyakanok and Roth, 2000), Conditional Random Fields (Lafferty et al., 2001), Sequence AdaBoost (Altun et al., 2003a), Sequence Perceptron (Collins, 2002), Hidden Markov Support Vector Machines (Altun et al., 2003b) and Maximum-Margin Markov Networks (Taskar et al., 2004), overcome the limitations of HMMs.
W02-1001
Among these methods, CRFs is the most common technique used in NLP and has been successfully applied to Part-of-Speech Tagging (Lafferty et al., 2001), Named-Entity Recognition (Collins, 2002) and shallow parsing (Sha and Pereira, 2003; McCallum, 2003).
N03-1028 W02-1001
