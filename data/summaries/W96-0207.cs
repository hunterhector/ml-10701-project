(See Oflazer and Kuru6z (1994) and KuruSz (1994) for details of all other forms for Turkish).
A94-1024
Levinger et al.(1995) have recently reported on an approach that learns morpholexical probabilities from untagged corpus and have the used the resulting information in morphological disambiguation in Hebrew.
J95-3004
Our previous approach to tagging and morphological disambiguation for Turkish text had employed a constraint-based approach (Oflazer and Kuru6z, 1994) along the general lines of similar previous work for English (Karlsson et al., 1995; Voutilainen et al., 1992; Voutilainen and Tapanainen, 1993).
A94-1024 E93-1046
Brill (1992; 1994; 1995a) has presented a transformation-based learning approach, which induces rules from tagged corpora.
A92-1021 J95-4004 W95-0101
In certain respects, our approach has been motivated by Brill's recent work (Brill, 1995b), but with the observation that his transformational approach is not directly applicable to languages like Turkish, where tags associated with forms are not predictable in advance.
J95-4004 W95-0101
For example, the feature structure above is projected into a feature structure such as: -CAT ADJ \[OAT NOUN \]\] |AGR 3SG |POSS 1SG STEM /CASE LOC /STEM \[CAT VERB \[SUFFIX DIK SUFFIX REL 3.2 Unknown Words Although the coverage of our morphological analyzer for Turkish (Oflazer, 1993), with about 30,000 root words and about 35,000 proper names, is very satisfactory, it is inevitable that there will be forms in the corpora being processed that are not recognized by the morphological analyzer.
E93-1066
In certain respects, our approach has been motivated by Brill's recent work (Brill, 1995b), but with the observation that his transformational approach is not directly applicable to languages like Turkish.
J95-4004 W95-0101
Another approach is the rule-based or constraint-based approach, recently most prominently exemplified by the Constraint Grammar work (Karlsson et al., 1995; Voutilainen, 1995b; Voutilainen et al., 1992; Voutilainen and Tapanainen, 1993), where a large number of hand-crafted linguistic constraints are used to eliminate impossible tags or morphological parses for a given word in a given context.
E93-1046 E95-1022
We proceed with the following schema which is an adaptation of Brill's formulation (Brill, 1995b): 9Turkish is a free constituent order language whose unmarked order is SOV.
J95-4004 W95-0101
Church. 1988.
A88-1019
evaluate the resulting disambiguated text by a number of metrics defined as follows (Voutilainen, 1995a): #Parses Ambiguity #Tokens Recall = #Tokens Correctly Disambiguatcd #Tokens ~Tokcns Correctly Disambiguated Precision = ~Parses In the ideal case where each token is uniquely and correctly disambiguated with the correct parse, both recall and precision will be 1.0.
E95-1022
DeRose. 1988.
J88-1003
Part-of-speech tagging systems have used either a statistical approach where a large corpora has been used to train a probabilistic model which then has been used to tag new text, assigning the most likely tag for a given word in a given context (e.g., Church (1988), Cutting et al.(1992), DeRose (1988)).
A88-1019 A92-1018 J88-1003
Recently he has extended this work so that learning can proceed in an unsupervised manner using an untagged corpus (Brill, 1995b).
J95-4004 W95-0101
In hand crafting these rules, we have used our experience from an earlier tagger (Oflazer and Kuruhz, 1994).
A94-1024
