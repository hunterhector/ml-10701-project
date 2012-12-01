We have argued that a model of the kind proposed in this paper is essential for parsing languages with freer word order, such as Dutch or Czech, where the model of Hockenmaier and Steedman (2002b) (and other models of surface dependencies) would systematically capture the wrong dependencies, even if only local dependencies are taken into account.
P02-1043
model of surface dependencies Hockenmaier and Steedman (2002b) define a surface dependency model (henceforth: SD) HWDep which captures word-word dependencies that are defined in terms of the derivation tree itself.
P02-1043
First, we review the dependency model proposed by Hockenmaier and Steedman (2002b).
P02-1043
State-of-the-art statistical parsers for Penn Treebank-style phrase-structure grammars (Collins, 1999), (Charniak, 2000), but also for Categorial Grammar (Hockenmaier and Steedman, 2002b), include models of bilexical dependencies defined in terms of local trees.
A00-2018 P02-1043 P99-1065
CBCJCSCRD0CLD2C6C8 B4CBCJCSCRD0CLD2C6C8B5BPC6C8 opened C6C8 its doors The model conditions DB BW on its own lexical category CR BW,onCW C0 BP CWCR C0 BNDB C0 CX and on the local tree AS in which the BW is generated (represented in terms of the categories CWC8BNC0BNBWCX): C8B4DB BW CYCR BW BNAS BP CWC8BNC0BNBWCXBNCW C0 BP CWCR C0 BNDB C0 CXB5 3 Predicate-argument structure in CCG Like Clark et al.(2002), we define predicateargument structure for CCG in terms of the dependencies that hold between words with lexical functor categories and their arguments.
P02-1042
In contrast to the conditional model of Clark et al.(2002), our model captures these dependencies in a sound and consistent manner.
P02-1042
Since there is no CCG treebank for other languages available, experimental results are presented for English, using CCGbank (Hockenmaier and Steedman, 2002a), a translation of the Penn Treebank to CCG.
P02-1043
Therefore, the head words of arguments (such as Smith) are generated in the following manner: C8B4DB CP CYCR CP BNCWCWCR CW BNDB CW CXBNCXBNCWCR CP BNDB CP CXCXB5 The head word of modifiers (such as yesterday)are generated differently: C8B4DB D1 CYCR D1 BNCWCWCR D1 BNDB D1 CXBNCXBNCWCR CW BNDB CW CXB5 Like Collins (1999) and Charniak (2000), the SD model assumes that word-word dependencies can be defined at the maximal projection of a constituent.
A00-2018 P99-1065
of the kind proposed by Hockenmaier and Steedman (2002b)) and used the new model as a re-ranker.
P02-1043
Undirectional recovery (UdirP/UdirR) evaluates only whether there is a dependency between DB and DB BC . Unlike unlabelled recovery, this does not pe2 Beam search is as in Hockenmaier and Steedman (2002b).
P02-1043
Parsing with generative models of predicate-argument structure Julia Hockenmaier IRCS, University of Pennsylvania, Philadelphia, USA and Informatics, University of Edinburgh, Edinburgh, UK juliahr@linc.cis.upenn.edu Abstract The model used by the CCG parser of Hockenmaier and Steedman (2002b) would fail to capture the correct bilexical dependencies in a language with freer word order, such as Dutch.
P02-1043
Since lexical categories are generated at the maximal projection, our model has the same structural probabilities as the LexCat model of Hockenmaier and Steedman (2002b).
P02-1043
We use the example of Dutch ditransitives, but our argument equally applies to other languages such as Czech (see Collins et al.(1999)). We argue that this problem can be avoided if instead the bilexical dependencies in the predicate-argument structure are captured, and propose a generative model for these dependencies.
P99-1065
On the Wall Street Journal task, the overall performance of this model is lower than that of the SD model of Hockenmaier and Steedman (2002b).
P02-1043
The conditional model used by the CCG parser of Clark et al.(2002) also captures dependencies in the predicate-argument structure; however, their model is inconsistent.
P02-1042
The input is POS-tagged using the tagger of Ratnaparkhi (1996).
W96-0213
This paper argues that probabilistic parsers should therefore model the dependencies in the predicate-argument structure, as in the model of Clark et al.(2002), and defines a generative model for CCG derivations that captures these dependencies, including bounded and unbounded long-range dependencies.
P02-1042
Like Clark et al.(2002), we do not take the lexical category of the dependent into account, and evaluate CWCWCRBNDBCXBNCXBNCW BNDB BC CXCX for labelled, and CWCW BNDBCXBN BNCW BNDB BC CXCX for unlabelled recovery.
P02-1042
