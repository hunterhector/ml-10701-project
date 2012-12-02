Yarowsky's (1993) study indicates that while information within a large window can be used to disambiguate nouns, for verbs and adjectives the size of the usable window drops off dramatically with distance from the target word.
H93-1052
A similar view underlies the class-based methods cited in Section 2.4.3 (Brown et al.1992; Pereira and Tishby 1992; Pereira, Tishby, and Lee 1993).
J92-4003 P93-1024
example, Gale, Church, and Yarowsky (1993) remark that it is difficult to find any sense other than the financial sense for the word bank in the Hansard corpus.
H93-1052 J93-1001
However, Buitelaar (1997) describes means to automatically generate CORELEX entries from corpora in order to create domain-specific semantic lexicons, thus demonstrating the potential to access larger-scale resources of this kind.
W97-0205
Since then, supervised learning from sense-tagged corpora has since been used by several researchers: Zernik (1990, 1991), Hearst (1991), Leacock, Towell, and Voorhees (1993), Gale, Church, and Yarowsky (1992d, 1993), Bruce and Wiebe (1994), Miller et al.(1994), Niwa and Nitta (1994), Lehman (1994), among others.
C92-2070 C94-1049 H92-1045 H93-1051 H93-1052 H94-1046 J93-1001 P92-1032 P94-1013 P94-1020 W93-0102
Recently, a class-based bootstrapping method for semantic tagging in specific domains has been proposed (Basili et al.1997). Sch~tze (1992, 1993) proposes a method that avoids tagging each occurrence in the training corpus.
W97-0211
Others have used the grosser sense divisions of thesauri such as Roget's; however, it is often difficult to assign a unique sense, or even find an appropriate one among the options (see, for example, Yarowsky \[1992\]).
C92-2070
Only homograph distinction is necessary for tasks such as speech synthesis or restoration of accents in text, while tasks such as machine translation require fine sense distinctions--in some cases finer than what monolingual dictionaries provide (see, for example, ten Hacken \[1990\]).
C90-2028
Yarowsky (1993) explicitly addresses the use of collocations in WSD work, but admittedly adapts the definition to his purpose as "the co-occurrence of two words in some defined relation".
H93-1052
Although the terminology is different, this is very similar to the notion of baseline tagging used in modern work (see, e.g., Gale, Church, and Yarowsky \[1992b\]).
C92-2070 H92-1045 P92-1032
No quantitative evaluation of this method is available, but Cowie, Guthrie, and Guthrie (1992) improve the method using simulated annealing and report results of 47% for sense distinctions and 72% for homographs.
C92-1056
Resnik contrasts his method of computing similarity to those which compute path length (e.g., Sussna 1993), arguing that the links in the WordNet taxonomy do not represent uniform distances (cf.
H93-1054
and V~ronis Introduction Other methods attempt to avoid entirely the need for a tagged corpus, such as many of those cited in the section below (e.g., Yarowsky \[1992\] who attacks both the tagging and data sparseness problems simultaneously).
C92-2070
In a related study, they make a claim that for a given discourse, ambiguous words are used in a single sense with high probability ("one sense per discourse") (Gale, Church, and Yarowsky 1992c).
C92-2070 H92-1045 P92-1032
Wilks' preference semantics (\[1968, 1969, 1973, 1975a, 1975b, 1975c, 1975d\]; see the survey by Wilks and Fass \[1990\]), which uses Masterman's primitives, is essentially a case-based approach to natural language understanding and one of the first specifically designed to deal with the problem of sense disambiguation.
T75-2009
Roget's International Thesaurus, which was put into machine-tractable form in the 1950s and has been used in a variety of applications including machine translation (Masterman 1957), information retrieval (Sparck-Jones 1964, 1986), and content analysis (Sedelow and Sedelow \[1969\], see also Sedelow and Sedelow \[1986, 1992\]), also supplies an explicit concept hierarchy consisting of up to eight increasingly refined levels/Typically, each occurrence of the same word under different categories of the thesaurus represents different senses of that word; i.e., the categories correspond roughly to word senses (Yarowsky 1992).
C92-2070
In recent work, syntactic information most often is simply part of speech, used invariably in conjunction with other kinds of information (McRoy 1992; Bruce and Wiebe 1994; Leacock, Chodorow, and Miller, this volume).
J92-1001 P94-1020
Dagan, Marcus, and Markovitch (1993) give the following example: the pair (chapter, describes) does not appear in their corpus; however, chapter is similar to book, introduction, and section, which are paired with describes in the corpus.
P93-1022
A significant roadblock to generalizing WSD work was the difficulty and cost of hand-crafting the enormous amounts of knowledge required for WSD: the so-called "knowledge acquisition bottleneck" (Gale, Church, and Yarowsky 1993).
H93-1052 J93-1001
In the mid-1980s, work began on the construction of large-scale knowledge bases by hand, for example, WordNet (Miller et al.1990; Fellbaum forthcoming-a), CyC (Lenat and Guha 1990), ACQUILEX (Briscoe 1991), COMLEX (Grishman, Macleod, and Meyers 1994; Macleod, Grishman, and Myers, forthcoming).
C94-1042
Yarowsky (1993) determines various behaviors based on syntactic category; for example, that verbs derive more disambiguating information from their objects than from their subjects, adjectives derive almost all disambiguating information from the nouns they modify, and nouns are best disambiguated by directly adjacent adjectives or nouns.
H93-1052
Aware of this problem, Resnik and Yarowsky suggest creating the sense distance matrix based on results in experimental psychology such as Miller and Charles (1991) or Resnik (1995b).
W95-0105
However, as demonstrated in Yarowsky's (1992) work, the approach is cheaper than those requiring more complex processing and can achieve sufficient disambiguation for some applications.
C92-2070
TM Gale, Church, and Yarowsky's (1992c) claim for one sense per discourse is disputable.
C92-2070 H92-1045 P92-1032
Recent WSD work has exploited topical context: Yarowsky (1992) uses a 100-word window, both to derive classes of related words and as context surrounding the polysemous target, in his experiments using Roget's Thesaurus (see Section 2.3.2).
C92-2070
Linguistics Volume 24, Number 1 As outlined in Buitelaar (1997), sense disambiguation in the generative context starts with a semantic tagging that points to a complex knowledge representation reflecting all of a word's systematically related senses, after which semantic processing may derive a discourse-dependent interpretation containing more precise sense information about the occurrence.
W97-0205
the survey of methods in Chen and Goodman (1996).
P96-1041
Reasoning often involves traversing an ontology to find common ancestors for words in context; her work anticipates Resnik's (1993a, 1993b, 1995a) results by determining that ontological similarity, involving a common ancestor in the ontology, is a powerful disambiguator.
H93-1054 W95-0105
Several authors (for example, Krovetz and Croft \[1989\], Guthrie et al.\[1991\], Slator \[1992\], Cowie, Guthrie, and Guthrie \[1992\], Janssen \[1992\], Braden-Harder \[1993\], Liddy and Paik \[1993\]) have attempted to improve results by using supplementary fields of information in the electronic version of the Longman Dictionary of Contemporary English (LDOCE), in particular, the box codes and subject codes provided for each sense.
C92-1056 P91-1019
primary area of activity during the 1980s involved attempts to automatically extract lexical and semantic knowledge bases from MRDs (Michiels, Mullenders, and No61 1980; Calzolari 1984; Chodorow, Byrd, and Heidon 1985; Markowitz, Ahlswede, and Evens 1986; Byrd et al.1987; Nakamura and Nagao 1988; Klavans, Chodorow, and Wacholder 1990; Wilks et al.1990). This work contributed significantly to lexical semantic studies, but it appears that the initial goalmthe automatic extraction of large knowledge bases--was not fully achieved: the only currently widely available large-scale lexical knowledge base (WordNet, see below) was created by hand.
C80-1057 C88-2098 J87-3003 P84-1036 P85-1037 P86-1018
Several efforts to create sense-tagged corpora have been or are being made: the Linguistic Data Consortium 15 Computational Linguistics Volume 24, Number 1 distributes a corpus of approximately 200,000 sentences from the Brown Corpus and the Wall Street Journal in which all occurrences of 191 words are hand-tagged with their WordNet senses (see Ng and Lee \[1996\]).
P96-1006
Sense disambiguation is also necessary for certain syntactic analyses, such as prepositional phrase attachment (Jensen and Binot 1987; Whittemore, Ferrara, and Brunner 1990; Hindle and Rooth 1993), and, in general, restricts the space of competing parses (Alshawi and Carter 1994).
J87-3005 J93-1005 J94-4005 P90-1004
Gale, Church, and Yarowsky (1992b) attempt to establish lower and upper bounds for evaluating the performance of WSD systems; their proposal for overcoming the problem of agreement among human judges in order to establish an upper bound provides a starting point, but it has not been widely discussed or implemented.
C92-2070 H92-1045 P92-1032
Research into means to facilitate and optimize tagging is ongoing; for example, an optimization technique called committee-based sample selection has recently been proposed (Engelson and Dagan 1996), which, based on the observation that a substantial portion of manually tagged examples contribute little to performance, enables avoiding the tagging of examples that carry more or less the same information.
P96-1042
Brown et al.(1992), Pereira and Tishby (1992), and Pereira, Tishby, and Lee (1993) propose methods that derive classes from the distributional properties of the corpus itself, while other authors use external information sources to define classes: Resnik (1992) uses the taxonomy of WordNet; Yarowsky (1992) uses the categories of Roget's Thesaurus, Slator (1992) and Liddy and Paik (1993) use the subject codes in the LDOCE; Luk (1995) uses conceptual sets built from the LDOCE definitions.
C92-2070 H93-1052 J92-4003 P93-1024 P95-1025
14 Dagan, Itai, and Schwall (1991) and Dagan and Itai (1994) propose a similar method, but instead of a parallel corpus use two monolingual corpora and a bilingual dictionary.
J94-4003 P91-1017 P94-1038
A recent discussion at a workshop sponsored by the ACL Special Interest Group on the Lexicon (SIGLEX) on "Evaluating Automatic SemanticTaggers" (Resnik and Yarowsky \[1997a\[; see also Resnik and Yarowsky \[1997b\], Kilgarriff \[1997\]) has sparked the formation of an evaluation effort for WSD (SENSEVAL), in the spirit of previous evaluation efforts such as the ARPA-sponsored Message Understanding Conferences (e.g., ARPA \[1993\]), and Text Retrieval Conferences (e.g.
W97-0213 W97-0217
Guthrie et al.(1991) demonstrate a typical use of this information: in addition to using the Lesk-based method of counting overlaps between definitions and contexts, they impose a correspondence of subject codes in an iterative process.
P91-1019
Resnik 1995b).
W95-0105
Like many class-based methods, such as Brown et al.(1992), similarity-based methods exploit a similarity metric between patterns of co-occurrence.
J92-4003
Gale, Church, and Yarowsky (1993), looking at a context of ±50 words, indicate that while words closest to the target contribute most to disambiguation, they improved their results from 86% to 90% by expanding context from ±6 (a typical span when only microcontext is considered) to ~50 words around the target.
H93-1052 J93-1001
Buitelaar (1997) describes the use of CORELEX for underspecifled semantic tagging (see also Pustejovsky, Boguraev, and Johnston \[1995\]).
W97-0205
Weaver discusses the role of the domain in sense disambiguation, making a point that was reiterated several decades later by Gale, Church, and Yarowsky (1992c): In mathematics, to take what is probably the easiest example, one can very nearly say that each word, within the general context of a mathematical article, has one and only one meaning.
C92-2070 H92-1045 P92-1032
Even ignoring the cost of creating such a matrix, the psycholinguistic literature has made clear that these results are highly influenced by experimental conditions and the task imposed on the subjects (see, for example, Tabossi \[1989, 1991\], Rayner and Morris \[1991\]); in addition, it is not clear that psycholinguistic data can be of help in WSD aimed toward practical use in NLP systems.
J91-1002
speech processing: sense disambiguation is required for correct phonetization of words in speech synthesis, for example, the word conjure in He conjured up an image or in I conjure you to help me (Sproat, Hirschberg, and Yarowsky 1992; Yarowsky 1997), and also for word segmentation and homophone discrimination in speech recognition (Connine 1990; Seneff 1992).
C92-2070 J92-1004
Voorhees' (1993) hood construct is an attempt to access sense distinctions that are less fine-grained than WordNet's synsets, and less coarse-grained than the 10 WordNet noun hierarchies; Resnik's (1995a) method allows for detecting sense distinctions at any level of the WordNet hierarchy.
W95-0105
These methods were rediscovered first in speech processing (e.g., Jelinek \[1976\]; see the overview by Church and Mercer \[1993\] and the collection of reprints by Waibel and Lee \[1990\]) and were immediately applied to written language analysis (e.g., in the work of Bahl and Mercer \[1976\], Debili \[1977\], etc.).
J93-1001
A more serious issue for this method is that it is not clear what the senses derived from the clusters correspond to (see, for example Pereira, Tishby, and Lee \[1993\]); moreover, the senses are not directly usable by other systems, since they are derived from the corpus itself.
P93-1024
Yarowsky (1993, 1994a, 1994b) examines different windows of microcontext, including 1-contexts, k-contexts, and words pairs at offsets -1 and -2, -1 and +1, and +1 and +2, and sorts them using a log-likelihood ratio to find the most reliable evidence for disambiguation.
H93-1052 P94-1013
Resnik and Yarowsky (1997b) also point out that a binary evaluation (correct/incorrect) for WSD is not sufficient, and propose that errors be penalized according to a distance matrix among senses based on a hierarchical organization.
W97-0213 W97-0217
Brown et al.(1991) and Gale, Church, and Yarowsky, (1992a, 1993) propose the use of bilingual corpora to avoid hand-tagging of training data.
C92-2070 H92-1045 H93-1052 J92-4003 J93-1001 P91-1034 P92-1032
Resnik and Yarowsky (1997b) have proposed that for WSD evaluation, 25 Computational Linguistics Volume 24, Number 1 it may be practical to retain only those sense distinctions that are lexicalized crosslinguistically.
W97-0213 W97-0217
Also, the Cognitive Science Laboratory at Princeton has undertaken the hand-tagging of 1,000 words from the Brown Corpus with WordNet senses (Miller et al.1993) (so far, 200,000 words are available via ftp), and hand-tagging of 25 verbs in a small segment of the Wall Street Journal (12,925 sentences), is also underway (Wiebe et al.1997). However, these corpora are far smaller than those typically used with statistical methods.
H93-1061 W97-0202
Similarity-based methods Dagan, Marcus, and Markovitch 1993, Dagan, Pereira, and Lee 1994, and Grishman and Sterling 1993 exploit the same idea of grouping observations for similar words, but without regrouping them into fixed classes.
H93-1050 J94-4003 P93-1022 P93-1024 P94-1038
While dictionaries provide detailed information at the lexical level, they lack pragmatic information that enters into sense determination (see, e.g., Hobbs \[1987\]).
T87-1006
Resnik (1995a) draws on his body of earlier work on WordNet, in which he explores a measure of semantic similarity for words in the WordNet hierarchy (Resnik 1993a, 1993b, 1995a).
H93-1054 W95-0105
Evidence suggests that different kinds of disambiguation procedures are needed depending on the syntactic category and other characteristics of the target word (Yarowsky 1993; Leacock, Chodorow, and Miller, this volume)--an idea reminiscent of the word expert approach.
H93-1052
Recognizing this, Dolan (1994) proposes a method for "ambiguating" dictionary senses by combining them to create grosser sense distinctions.
C94-2113
Yarowsky (1992) derives classes of words by starting with words in common categories in Roget's (4th edition).
C92-2070
Dagan, Marcus, and Markovitch's (1993) evaluation seems to show that similarity-based methods perform better than class-based methods.
P93-1022
Voorhees, Leacock, and Towell (1995) experiment with several statistical methods using a two-sentence window; Leacock, Towell, and Voorhees (1993, 1996) have similarly explored topical context for WSD.
H93-1051 W93-0102
It has been noted that the repetition of words within successive segments or sentences is a strong indicator of the structure of discourse (Skorochod'ko 1972; Morris 1988; Morris and Hirst 1991); methods exploiting this observation to segment a text into subtopics are beginning to emerge (see, for example, Hearst \[1994\], van der Eijk \[1994\], Richmond, Smith, and Amitay \[1997\]).
J91-1002 P94-1002 W97-0305
text processing: sense disambiguation is necessary for spelling correction (for example, to determine when diacritics should be inserted, such as in French, changing comte to comte \[Yarowsky 1994a, 1994b\]); for case changes (HE READ THE TIMES ~ He read the Times); for lexical access of Semitic languages (in which vowels are not written), etc.
P94-1013
(Hayes 1977a, 1997b; Wilks 1973 and 1975b; Hirst 1987).
T75-2009
