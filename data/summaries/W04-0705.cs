The HMM tagger generally follows the NYMBLE model (Bikel et al, 1997), but with a larger number of states (12) to handle name prefixes and suffixes, and transliterated foreign names separately.
A97-1029
Other systems have made a second tagging pass which uses information on token sequences tagged in the first pass (Borthwick 1999), or have used as features information about features assigned to other instances of the same token (Chieu and Ng 2002).
C02-1025
Usually people adopt a separate list of abbreviations or design separate rules (Sun et al.2002) to identify them.
C02-1012
We have used the MUC coreference scoring metric (Vilain et al, 1995) to evaluate this resolver, excluding all pronouns and limiting ourselves to noun phrases of semantic type PER, ORG, and GPE.
M95-1005
A wide variety of machine learning methods have been applied to this problem, including Hidden Markov Models (Bikel et al.1997), Maximum Entropy methods (Borthwick et al.1998, Chieu and Ng 2002), Decision Trees (Sekine et al.1998), Conditional Random Fields (McCallum and Li 2003), Class-based Language Model (Sun et al.2002), Agent-based Approach (Ye et al.2002) and Support Vector Machines.
A97-1029 C02-1012 C02-1025 C02-1080 W03-0430 W98-1118 W98-1120
In particular, most of these methods classify an instance of a name based on the information about that instance alone, and very local context of that instance – typically, one or 1 The best results reported for Chinese named entity recognition, on the MET-2 test corpus, are 0.92 to 0.95 F-measure for the different name types (Ye et al.2002). two words preceding and following the name.
C02-1080
The problem of name recognition and classification has been intensively studied since 1995, when it was introduced as part of the MUC6 Evaluation (Grishman and Sundheim, 1996).
C96-1079
