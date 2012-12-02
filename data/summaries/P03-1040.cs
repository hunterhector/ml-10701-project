This decoder employs hypothesis recombination and stores the search states in a search graph – similar to work by Ueffing et al.(2002) – which can be mined with standard finite state machine methods5 for n-best lists.
W02-1021
Performance is also measured by the BLEU score (Papineni et al., 2002), which measures similarity to the reference translation taken from the English side of the parallel corpus.
P02-1040
Details of this model are described by Koehn et al.(2003). To obtain an n-best list of candidate translations, we developed a beam search decoder.
E03-1076 N03-1017
Then, we parse both sides with syntactic parsers (Collins, 1997; Schmidt and Schulte im Walde, 2000)2.
C00-2105
We use the toolkit7 developed by Malouf (2002).
W02-2018
As a baseline, we use an IBM Model 4 (Brown et al., 1993) system3 with a greedy decoder4 (Germann et al., 2001).
J93-2003 P01-1030
First, we word-align the corpus with Giza++ (Och and Ney, 2000).
P00-1056
Berger et al.(1996) and Manning and Sch¨utze (1999) provide good introductions to maximum entropy learning.
J96-1002
Here, we follow an approach introduced by Koehn and Knight (2003): First, we collect frequency statistics over words in our training corpus.
E03-1076 N03-1017
This method is also similar to work by Och and Ney (2002), who use maximum entropy to tune model parameters.
P02-1038
Previous work on defining subtasks within statistical machine translation has been performed on, e.g., noun-noun pair (Cao and Li, 2002) and named entity translation (Al-Onaizan and Knight, 2002).
C02-1011 P02-1051
