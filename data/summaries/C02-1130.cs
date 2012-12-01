Bechet et al.(2000) use a decision tree algorithm to classify unknown proper names into the categories: first name, last name, country, town, and organization.
P00-1011
A topic signature, as described in (Lin and Hovy, 2000), is a list of terms that can be used to signal the membership of a text in the relevant topic or category.
C00-1072
Wacholder et al.(1997) use hand-written rules and knowledge bases to classify proper names into broad categories.
A97-1030
We implemented the algorithm described in (Lin and Hovy, 2000) with the addition of a cutoff, such that the topic signatures for a term are only included if the p1/p2 for that term is greater than the mean p1/p2 over all terms.
C00-1072
The topic signatures are automatically generated for each specific term by computing the likelihood ratio (λ-score) between two hypotheses (Dunning, 1993).
J93-1003
In future work, we will investigate more sophisticated bootstrapping methods, as (Collins & Singer, 1999) as well as co-training and co-testing (Muslea et al., 2000).
W99-0613
