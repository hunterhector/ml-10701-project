This paper applies the SABLE system to a much smaller (approximately 400,000 word) corpus in a technical domain, and assesses its potential contribution to the semi-automatic acquisition process outlined above, very much in the spirit of Dagan and Church (1994) and Daille et al.(1994), but beginning with a higher accuracy starting point and focusing on mono-word terms.
A94-1006
This re-estimation paradigm was pioneered by Brown et al.(1993). However, their models were not designed for human inspection, and though some have tried, it is not clear how to extract translation lexicons from their models (Wu and Xia, 1995).
J93-2003
As Melamed (1996b) observes, SABLE's output groups naturally according to "plateaus" of likelihood (see Figure 2).
W96-0201
SABLE uses token co-occurrence statistics to induce an initial translation lexicon, using the method described in (Melamed, 1995).
W95-0115
SIMR is equipped with several "plug-in" matching heuristic modules which are based on cognates (Davis et al., 1995; Simard et al., 1992; Melamed, 1995) and/or "seed" translation lexicons (Chen, 1993).
E95-1010 P93-1002 W95-0115
Algorithms that map bitext correspondence at the phrase or sentences level are limited in their applicability to bitexts that have easily recognizable phrase or sentence boundaries, and Church (1993) reports that such bitexts are far more rare than one might expect.
P93-1001
of Context Melamed (1996b) suggests that evaluation of translation lexicons requires that judges have access to bilingual concordances showing the contexts in which proposed word pairs appear; however, out-ofcontext judgments would be easier to obtain in both experimental and real-world settings.
W96-0201
The SABLE system (Melamed, 1996b) makes no attempt to handle collocations, but for single-word to single-word translations it offers a very accurate method for acquiring high quality translation lexicons from very large parallel corpora: Melamed reports 90+% precision at 90+% recall, when evaluated on sets of Hansards data of 6-7 million words.
W96-0201
Following Melamed (1996b), we adopt the following approach to measuring recall: the upper bound is defined by the number of different words in the bitext.
W96-0201
Translation lexicon recall can be automatically computed with respect to the input bitext (Melamed, 1996b), so SABLE users have the option of specifying the recall they desire in the output.
W96-0201
Early efforts at extracting translation lexicons from bitexts deemed two tokens to co-occur if they occurred in aligned sentence pairs (Gale and Church, 1991).
H91-1026
Bitext Correspondence After both halves of the input bitext(s) have been tokenized, SABLE invokes the Smooth Injective Map Recognizer (SIMR) algorithm (Melamed, 1996a) and related components to produce a bitext map.
W96-0201
On the other end of the spectrum, character-based bitext mapping algorithms (Church, 1993; Davis et al., 1995) are limited to language pairs where cognates are common; in addition, they may easily be misled by superficial differences in formatting and page layout and must sacrifice precision to be computationally tractable.
E95-1010 P93-1001
Davis and Dunning (1995), for example, generate target-language queries using a corpus-based technique that is similar in several respects to the work described here.
E95-1010
(Daille, 1996; Smadja, 1993)), less prior work exists for bilingual acquisition of domain-specific translations.
J93-1007
The porting process has been standardized and documented (Melamed, 1996c).
W96-0201
The Champollion system (Smadja, McKeown, and Hatzivassiloglou, 1996) moves toward higher accuracy (around 73%) and considerably greater flexibility in the handling of multi-word translations, though the algorithm has been applied primarily to very large corpora such as the Hansards (3-9 million words; Smadja et al.observe that the method has difficulty handling low-frequency cases), and no 340 attempt is made to distinguish corpus-dependent translations from general ones.
J96-1001
Lexicon Extraction Since bitext maps can represent crossing correspondences, they are more general than "alignments" (Melamed, 1996a).
W96-0201
of Annotations In order to assess the consistency of annotation, we follow Carletta (1996) in using Cohen's ~, a chancecorrected measure of inter-rater agreement.
J96-2004
