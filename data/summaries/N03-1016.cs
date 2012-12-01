Roark (2001) and Ratnaparkhi (1999) use a beam-search strategy, in which only the best n parses are tracked at any moment.
J01-2004
On the other hand, the more complex, tuned FOM in (Charniak et al., 1998) is able to parse all of these sentences using around 2K edges, while BF requires 7K edges.
W98-1115
Additionally, with I-tries, only the top-level intermediate rules have probability less than 1, while for O-tries, one can back-weight probability as in (Mohri, 1997), also shown in figure 5, enabling sub-parts of rare rules to be penalized even before they are completed.8 For all subsequent results, we discuss only the O-trie numbers.
J97-2003
I-TRIE is a non-deterministic leftbranching trie with weights on rule entry as in Charniak et al.(1998). states, such as by annotating nodes with their parent and even grandparent categories (Johnson, 1998).
J98-4004 W98-1115
It is worth explicitly discussing how the F estimate differs from top-down grammar-driven filtering standardly used by top-down chart parsers; in the treebank grammar, there is virtually no top-down filtering to be exploited (again, see Klein and Manning (2001b)).
P01-1044
To situate our results, the FOMs used by (Caraballo and Charniak, 1998) require 10K edges to parse 96% of these sentences, while BF requires only 6K edges.
J98-2004 W98-1115
If one uses b(e,s) to prioritize edges, we show in Klein and Manning (2001a), that the parser is optimal over arbitrary PCFGs, and a wide range of control strategies.
P01-1044
The proof of this is very similar to the proof of the uniform-cost case in Klein and Manning (2001a), and so we omit it for space reasons (it can be found in Klein and Manning, 2002).
P01-1044
I-tries are as in Charniak et al.(1998), where NP→ DT JJ NN becomes NP → XDT JJ NN and XDT JJ → DT JJ, and correspond to dropping the portion of an Earley dotted rule after the dot.7 O-tries, as in Leermakers (1992), turn NP→ DT JJ NN into NP → XNP→ · NN NN and XNP→ · NN → DT JJ, and correspond to 6We chose the data set used by Charniak and coauthors, so as to facilitate comparison with previous work.
W98-1115
Best-first parsers deal with this by allowing an upward propagation, which updates such edges’ scores (Caraballo and Charniak, 1998).
J98-2004 W98-1115
Chitrao and Grishman (1990), Caraballo and Charniak (1998), Charniak et al.(1998), and Collins (1999) describe best-first parsing, which is intended for a tabular item-based framework.
H90-1053 J98-2004 W98-1115
In best-first parsing, this priority is called a figure-of-merit (FOM), and is based on various approximations to P(e|s), the fraction of parses of a sentence s which include an edge e (though see Goodman (1997) for an alternative notion of FOM).
W97-0302
Performance Following (Charniak et al., 1998), we parsed unseen sentences of length 18–26 from the Penn Treebank, using the grammar induced from the remainder of the treebank.6 We tried all estimates described above.
W98-1115
7In Charniak et al.(1998), the binarization is in the reverse direction; we binarize into a left chain because it is the standard direction implicit in chart parsers’ dotted rules, and the direction makes little difference in edge counts.
W98-1115
The complex FOMs in (Charniak et al., 1998) require somewhat more online computation to assemble.
W98-1115
O-TRIE is a deterministic right-branching trie encoding (Leermakers, 1992) with weights pushed left (Mohri, 1997).
J97-2003
As discussed in Klein and Manning (2001b), the only source of constraint on what edges can be built where is the tags in the rules.
P01-1044
However, the present algorithm and estimates work just as well for top-down chart parsing, given suitable active items as nodes; see (Klein and Manning, 2001a).
P01-1044
