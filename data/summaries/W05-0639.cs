Our system uses the heuristic rules introduced by (Xue and Palmer, 2004).
W04-3212
(Gildea and Palmer, 2002; Pradhan et al., 2005; Punyakanok et al., 2004) However, these SRL systems generally extract features from sentences processed by a syntactic parser or other shallow parsing components, such as a chunker and a clause identifier.
C04-1197 J05-1004 P02-1031
Mitchell Marcus, Grace Kim, Mary AnnMarcinkiewicz, et al.1994. The Penn Treebank: Annotating Predicate Argument Structure.
H94-1020
The lexical features we use to train these two components are taken from (Xue and Palmer, 2004).
W04-3212
Previous SRL systems usually use a pure syntactic parser, such as (Charniak, 2000; Collins, 1999), to retrieve possible constituents.
A00-2018
The idea is to augment the Penn Treebank (Marcus et al., 1994) constituent labels with the semantic role labels from the PropBank (Palmer et al., 2005), and generate a rich training corpus.
H94-1020 J05-1004
In order to attack this problem, in addition to Charniak’s parser (Charniak, 2000), our system combine two parser which are trained on both syntactic constituent information and semantic argument information.
A00-2018
