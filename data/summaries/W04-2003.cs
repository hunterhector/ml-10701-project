Statistical disambiguation such as (Collins and Brooks, 1995) for PP-attachment or (Collins, 1997; Charniak, 2000) for generative parsing greatly improve disambiguation, but as they model by imitation instead of by understanding, complete soundness has to remain elusive.
A00-2018 P97-1003 W95-0103
Parsing algorithms able to treat completely unrestricted long-distance dependencies are NPcomplete (Neuhaus and Br¨oker, 1997).
P97-1043
Practical experiments have shown, however, that, in accordance to (Gildea, 2001) on head-lexicalisation, there is almost no increase in performance.
W01-0521
A number of robust statistical parsers that oﬀer solutions to these problems have now become available (Charniak, 2000; Collins, 1999; Henderson, 2003), but they typically produce CFG constituency data as output, trees that do not express long-distance dependencies.
A00-2018 N03-1014
” (Johnson, 2002).
P02-1018
Few hand-crafted, deep linguistic grammars achieve the coverage and robustness needed to parse large corpora (see (Riezler et al., 2002) for an exception, and (Burke et al., 2004; Hockenmaier and Steedman, 2002) for approaches extracting formal grammars from the Treebank), and speed remains a serious challenge.
P02-1035 P02-1043
The trees obtained from parsing can be decompressed into traditional constituency trees including empty nodes and co-indexation, or into shallow semantic structures such as Minimal Logical Forms (MLF) (Rinaldi et al., 2004b; Schneider et al., 2000; Schwitter et al., 1999).
W04-0508
2.4 Long-distance Dependencies Long-distance dependencies exponentially increase parsing complexity (Neuhaus and Br¨oker, 1997).
P97-1043
The performance, shown in table 2, is, according to (Preiss, 2003), similar to a large selection of statistical parsers and a grammatical relation finder.
E03-1025
(Schneider, 2003a) shows that the vast majority of LDDs can be treated in this way, essentially compressing non-local subtrees into dedicated relations even before grammar writing starts.
N03-3006
It is therefore necessary to either discard infrequent rules, do manual editing, use a diﬀerent rule format such as individual dependencies (Collins, 1996) or gain full linguistic control and insight by using a handwritten grammar – each of which sacrifices total completeness.
P96-1025
and Evaluation Pro3Gres is currently being applied in a Question Answering system specifically targeted at Figure 3: Dependency Tree output of the SWI Prolog graphical implementation of the parser technical domains (Rinaldi et al., 2004b).
W04-0508
The dependency relations provided by a parser such as Pro3Gres, combined with domain specific axioms, allow the creation of (some of) the semantic annotations, as described in (Rinaldi et al., 2003; Kaljurand et al., 2004).
W04-0508
For these reasons, (Johnson, 2002) provocatively refers to them as “halfgrammars”.
P02-1018
In detail, (1) before the parsing we model dedicated patterns across several levels of constituency subtrees partly leading to dedicated, compressed and fully local dependency relations, (2) we use statistical lexicalized postprocessing, and (3) we rely on traditional Dependency Grammar assumptions (section 2.2). 2.4.1 Pre-processing (Johnson, 2002) presents a pattern-matching algorithm for post-processing the output of statistical parsers to add empty nodes to their parse trees.
P02-1018
But the most striking characteristic of this domain is the frequency of MultiWord Terms (MWT) which are known to cause serious problems for NLP systems (Sag et al., 2002), (Dowdall et al., 2003).
W03-1801
Instead of manually selecting what goes into the history, as is usually done (see (Henderson, 2003) for an exception), we manually select how to linguistically meaningfully map Treebank structures onto dependency relations by the use of mapping patterns adapted from (Johnson, 2002).
N03-1014 P02-1018
Dependency Grammar We follow the broad architecture suggested by (Abney, 1995) which naturally integrates chunking and dependency parsing and has proven to be practical, fast and robust (Collins, 1996; Basili and Zanzotto, 2002).
P96-1025
(Dienes and Dubey, 2003) show that finite-state preprocessing modules can successfully deal with LDDs.
W03-1005
rule-based the most obvious way in which Pro3Gres is a hybrid (Schneider, 2003b).
N03-3006
The modified QA system (using Pro3Gres) is being exploited in the area of ‘Life Sciences’, for applications concerning Knowledge Discovery over Medline abstracts (Rinaldi et al., 2004a; Dowdall et al., 2004).
W04-0508
We have applied structural patterns to the Penn Treebank, where like in perfect parses precision and recall are high, and where in addition functional labels and empty nodes are available, so that patterns similar to Johnson’s but – like (Jijkoun, 2003) – relying on functional labels and empty nodes reach precision close to 100%.
P03-2006
Although grammatical function and empty nodes annotation expressing long-distance dependencies are provided in Treebanks such as the Penn Treebank (Marcus et al., 1993), most statistical Treebank trained parsers fully or largely ignore them 1, which entails two problems: first, the training cannot profit from valuable annotation data.
J93-2004
phrase modpp draft of paper noun–participle modpart report written verb–complementizer compl to eat apples noun–preposition prep to the house Table 1: The most important dependency types used by the parser ? a104 a104 a104 a104 a104 a40 a40 a40 a40 a40 NP-SBJ-X@ noun VP@ a104 a104 a104 a40 a40 a40 V passive verb NP -NONE*-X ? a104 a104 a104 a104a104 a40 a40 a40 a40a40 NP-SBJ-X@ noun VP@ a104 a104 a104 a40 a40 a40 V control-verb S NP-SBJ -NONE*-X Figure 1: The extaction patterns for passive subjects (top) and subject control (bottom) DG (Hajiˇc, 1998), (Tapanainen and J¨arvinen, 1997).
A97-1011
(Kaplan et al., 2004).
N04-1013
Our approach can be seen as an extension of (Collins and Brooks, 1995) from PP-attachment to most dependency relations.
W95-0103
“Much of the interesting work is determining what goes into [the history] H(c)”(Charniak, 2000).
A00-2018
This leads to much flatter trees, as typical for DG, which has the advantages that (1) it helps to alleviate sparse data by mapping nested structures that express the same dependency relation, (2) the costly overhead for dealing with unbounded dependencies can be largely avoided, (3) it is ensured that the lexical information that matters is available in one central place, allowing the parser to take one well-informed decision instead of several brittle decisions plagued by sparseness, which greatly reduces complexity and the risk of errors (Johnson, 2002).
P02-1018
Our approach is to use finite-state approximations of long-distance dependencies, as they are described in (Schneider, 2003a) for Dependency Grammar (DG) and (Cahill et al., 2004) for Lexical Functional Grammar (LFG).
N03-3006 P04-1041
