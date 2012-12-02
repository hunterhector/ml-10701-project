E. Black et al.1991. Procedure for quantitatively comparing the syntactic coverage of English grammars.
H91-1060
Given that state-of-the-art edit detection performs at about 80% f-measure (Johnson and Charniak, 2004), much of the benefit derived here from oracle repair detection should be realizable in practice.
P04-1005
Consequently, they relaxed standard PARSEVAL (Black et al., 1991) to treat EDITED constituents like punctuation: adjacent EDITED constituents are merged, and the internal structure and attachment of EDITED constituents is not evaluated.
H91-1060
Extending the arguments of Charniak and Johnson with regard to repairs (2001), we argue there is little value in recovering the syntactic structure 1See (Core and Schubert, 1999) for a prototypical counterexample that rarely occurs in practice.
N01-1016 P99-1053
For our out-of-domain training condition, the parser was trained on sections 2-21 of the Wall Street Journal (WSJ) corpus (Marcus et al., 1993).
J93-2004
Our method for early deletion generalizes the approach used with repairs in (Charniak and Johnson, 2001): contiguous filler and edit words are deleted from the input strings, the strings are parsed, and the removed words are reinserted into the output trees under the appropriate flat constituent, FILLER or EDITED.
N01-1016
Our division of the corpus follows that used in (Charniak and Johnson, 2001).
N01-1016
While one study has shown that the presence of interjection and parenthetical constituents in conversational speech reduces parse accuracy (Engel et al., 2002), these constituent types are defined to cover both fluent and disfluent speech phenomena (Taylor, 1996), leaving the impact of fillers alone unclear.
W02-1007
We also tried automatically changing numbers, symbols, and abbreviations in the training text to match how they would be read (Roark, 2002), but this did not improve accuracy and so is not discussed further.
P02-1037
It is still worth noting, however, that the parser does perform better when fillers are absent, consistent with Engel et al.’s findings (2002).
W02-1007
Metrics As discussed earlier (§1), Charniak and Johnson (2001) have argued that speech repairs do not 2http://nlp.stanford.edu/software/tsurgeon.shtml 3http://www.cpan.org 74 contribute to meaning and so there is little value in syntactically analyzing repairs or evaluating our ability to do so.
N01-1016
Earlier work had already made this claim regarding speech repairs1 and argued that there was consequently little value in syntactically analyzing repairs or evaluating our ability to do so (Charniak and Johnson, 2001).
N01-1016
The dependency metric performs syntactic head-matching for each word using a set of given head percolation rules (derived from Charniak’s parser (2000)), and its relaxed formulation ignores terminals spanned by FILLER and EDITED constituents.
A00-2018
Alternative methods of integrating detected filler information, such as parse reranking (Kahn et al., 2005), also merit investigation.
H05-1030
Readability studies have shown that disfluencies (fillers and speech repairs) may be deleted from transcripts without compromising meaning (Jones et al., 2003), and deleting repairs prior to parsing has been shown to improve its accuracy (Charniak and Johnson, 2001).
N01-1016
For our study, a state-of-the-art filler detector (Johnson et al., 2004) is employed to delete fillers prior to parsing.
P04-1005
Edit word detection varies between parser and oracle, and filler word detection varies between none, system (Johnson et al., 2004), and oracle.
P04-1005
J.G. Kahn et al.2005. Effective use of prosody in parsing conversational speech.
H05-1030
Results shown for repair detection accuracy and its impact on parsing are consistent with previous work (Charniak and Johnson, 2001; Kahn et al., 2005; Harper et al., 2005).
H05-1030 N01-1016
Reported experiments measure the effect of early deletion under in-domain and out-of-domain parser training conditions using a state-of-the-art parser (Charniak, 2000).
A00-2018
This section reports parsing experiments studying the effect of early deletion under in-domain and outof-domain parser training conditions using the August 2005 release of the Charniak parser (2000).
A00-2018
Given our particular interest in fillers, we also report the effect of detecting them via a state-of-the-art system (Johnson et al., 2004).
P04-1005
M. Marcus et al.1993. Building a large annotated corpus of English: The Penn Treebank.
J93-2004
Moreover, this work showed that collateral damage to parse accuracy caused by repairs could be averted by deleting them prior to parsing, and this finding has been confirmed in subsequent studies (Kahn et al., 2005; Harper et al., 2005).
H05-1030
Experiments performed (§3.3) use a state-of-the-art parser (Charniak, 2000) to study the impact of early filler deletion under in-domain and out-of-domain (i.e.
A00-2018
