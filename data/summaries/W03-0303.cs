Bracketing In [Wu 1997], the Bilingual Bracketing PCFG was introduced, which can be simplified as the following production rules: A ! [AA] (1) A ! < AA > (2) A ! f=e (3) A ! f=null (4) A ! null=e (5) Where f and e are words in the target vocabulary Vf and source vocabulary Ve respectively.
J97-3002
However, instead of estimating the probabilities for the production rules via EM as described in [Wu 1997], we assign the probabilities to the rules using the Model-1 statistical translation lexicon [Brown et al.1993]. Because the syntactic A-production rules do not compete with the lexical rules, we can set them some default values.
J93-2003 J97-3002
In this paper, we use a simplified bilingual bracketing grammar together with a statistical translation lexicon such as the Model-1 lexicon [Brown 1993] to do the bilingual bracketing.
J93-2003
Bilingual Bracketing [Wu 1997] is one of the bilingual shallow parsing approaches studied for Chinese-English word alignment.
J97-3002
Lance Ramshaw and Mitchell Marcus 1995.
W95-0107
The base noun detector is [Ramshaw 1995].
W95-0107
More suitable ways could be bilingual chunk parsing, and refining the bracketing grammar as described in [Wu 1997].
J97-3002
The phrase boundaries can be obtained by using a base noun phrase detection toolkit [Ramshaw 1995], and the boundaries are loaded into the bracketing program.
W95-0107
