A more detailed description of a phrase-based approach to statistical machine translation will be given in section 2.2. 2.2 Review of phrase-based translation system For the confidence measures which will be introduced in section 5, we use a state-of-the-art phrasebased approach as described in (Zens and Ney, 2004).
N04-1033
For a description of this system, see (Kanthak et al., 2005).
W05-0831
Och. 2003.
P03-1021
Therefore, we determine the maximal translation probability of the target word e over the source sentence words: pIBM−1(e|fJ1 ) = maxj=0,...,J p(e|fj), (9) where f0 is the “empty” source word (Brown et al., 1993).
J93-2003
Nowadays, most of the state-of-the-art SMT systems are based on bilingual phrases (Bertoldi et al., 2004; Koehn et al., 2003; Och and Ney, 2004; Tillmann, 2003; Vogel et al., 2004; Zens and Ney, 2004).
J04-4002 N03-1017 N04-1033 P03-1021 W03-1001
Most of the word-level confidence measures which have been presented in the literature so far are either based on relatively simple translation models such as IBM-1 (Blatz et al., 2003) or make use of information provided by the SMT system such as N-best lists or word graphs (Blatz et al., 2003; Gandrabur and Foster, 2003; Ueffing et al., 2003).
W03-0413
Only recently have researchers started to investigate confidence measures for machine translation (Blatz et al., 2004; Gandrabur and Foster, 2003; Quirk, 2004; Ueffing et al., 2003).
C04-1046 W03-0413
Investigations on the use of the IBM-1 model for word confidence measures showed promising results (Blatz et al., 2003; Blatz et al., 2004).
C04-1046
A detailed analysis will be given for two of them; the so-called alignment template system (Och and Ney, 2004), (denoted as AT in the tables) and the phrase-based translation system described in section 2.2 (denoted as PBT in the tables).
J04-4002
Possible applications for confidence measures include • post-editing, where words with low confidence could be marked as potential errors, • improving translation prediction accuracy in trans-type-style interactive machine translation (Gandrabur and Foster, 2003; Ueffing and Ney, 2005), • combining output from different machine translation systems: hypotheses with low confidence can be discarded before selecting one of the system translations (Akiba et al., 2004), or the word confidence scores can be used for generating new hypotheses from the output of different systems (Jayaraman and Lavie, 2005), or the sentence confidence value can be employed for re-ranking (Blatz et al., 2003).
C04-1047 W03-0413
The model scaling factors λ1,...,λ5 and the word and phrase penalties are optimized with respect to some evaluation criterion (Och, 2003), e.g.
P03-1021
