Yarowsky et al., 2001) has been limited to inducing part-of-speech taggers in second languages (such as French or Czech) that only assign tags at the granularity of their source language (i.e.
H01-1035
Bangalore and Joshi (1999) have utilized “supertags” based on tree-structures of various complexity in the tree-adjoining grammar model.
J99-2004
2.3 Projection-based Bootstrapping Yarowsky et al.(2001) performed early work in the cross-lingual projection of part-of-speech tag annotations from English to French and Czech, by way of word-aligned parallel bilingual corpora.
H01-1035
Smith 2004.
W04-3207
For example, we have put off implementing tagging of gender given the notoriously arbitrary and inconsistent assignment of grammatical gender across languages (although Cucerzan and Yarowsky (2003) were able to show success on projection-based analysis of grammatical gender as well).
N03-1006
Probst (2003) pursued a similar methodology for the purposes of tag projection, using a somewhat expanded tagset inventory (e.g.
W03-0414
We investigated four individual approaches for the syntax-features – a regular-expression-based quasi-parser, a system based on Dekang Lin’s MiniPar (Lin, 1993), a system based on the Collins parser (Collins, 1999), and one based on the CMU Link Grammar Parser (Sleator and Temperley, 1993), as well as a family of voting-based combination schemes.
P93-1016
6 Cross-lingual POS Tag Projection and Bootstrapping Our cross-lingual POS tag projection process is similar to Yarowsky et al.(2001). It begins by performing a statistical sentence and word alignment of the bilingual corpora (described below), and then transfers both the coarseand fine-grained tags achieved from classifier combination on the English side via the higher confidence word alignments (based on the intersection of the 1-best word alignments induced from French to English and English to French.
H01-1035
‘WITH’ Figure 2: Example of fined-grained POS tags projected onto a French translation 3 Tagsets We use Penn treebank-style part-of-speech tags as a substrate for further enrichment (for all of the experiments described here, text was first tagged using the fnTBL part-of-speech tagger (Ngai and Florian, 2001)).
N01-1006
Probst. 2003.
W03-0414
Using such tags, Brants (2000) has achieved the automated tagging of a syntactic-structure-based set of grammatical function tags including phrase-chunk and syntactic-role modifiers trained in supervised mode from a treebank of German.
A00-1031
We used the methods of Yarowsky et al.(2001) to develop a core part-of-speech tagger for French, based only on the projected core tags, and used this as a basis for fine-grained tags.
H01-1035
Cucerzan and Yarowsky (2003) addressed the problem of grammatical gender projection via the use of small seed sets based on natural gender.
N03-1006
Smith and Smith, 2004).
W04-3207
Word alignments were produced using GIZA++ (Och and Ney, 2000) set to produce a maximum of one English word link for each French word (i.e., a French-toEnglish model).
P00-1056
