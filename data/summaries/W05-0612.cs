Implementation of constraints and preferences can be based on empirical insight (Lappin and Leass, 1994), or machine learning from a reference88 annotated corpus (Ge et al., 1998).
J94-4002 W98-1119
Incorporating context only through the governing constituent was also done in (Ge et al., 1998).
W98-1119
We use the limited memory variable metric method as implemented in Malouf’s maximum entropy package (2002) to set our weights.
W02-2018
For example, we anticipate that sentences with quotation marks will be problematic, as other researchers have observed that quoted text requires special handling for pronoun resolution (Kennedy and Boguraev, 1996).
C96-1021
This approach is quite different from Lappin and Leass (1994), who always include all future nouns from the current sentence as candidates, with a constant penalty added to possible cataphoric resolutions.
J94-4002
When labeled training data is available, we can use the Maximum Entropy principle (Berger et al., 1996) to optimize the λ weights.
J96-1002
To this end, we follow the approach of (Och and Ney, 2002) very closely, including their handling of multiple correct answers.
P02-1038
Instead, pleonastics are identified syntactically using an extension of the detector developed by Lappin and Leass (1994).
J94-4002
92 4.2 Implementation Details To get the context values and implement the syntactic filters, we parsed our corpora with Minipar (Lin, 1994).
C94-1079
As an alternative to co-training, Ng and Cardie (2003) use EM to augment a supervised coreference system with unlabeled data.
N03-1023
Following the approach in (Och and Ney, 2002), we can view the right-hand-side of Equation 5 as a special case of: exp parenleftBigg λ1 log Pr(p|l) + λ2 log Pr(k|l)+ λ3 log Pr(l) + λ4 log Pr(j) parenrightBigg (8) where ∀i : λi = 1.
P02-1038
Our methods are most influenced by IBM’s Model 1 (Brown et al., 1993).
J93-2003
Machine-learned, fully-automatic systems are more common in noun phrase coreference resolution, where the method of choice has been decision trees (Soon et al., 2001; Ng and Cardie, 2002).
J01-4004 P02-1014
Training on unambiguous cases is similar in spirit to (Hindle and Rooth, 1993).
J93-1005
There are also approaches to anaphora resolution using unsupervised methods to extract useful information, such as gender and number (Ge et al., 1998), or contextual role-knowledge (Bean and Riloff, 2004).
N04-1038 W98-1119
