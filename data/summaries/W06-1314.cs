The creation of the ICSI corpus (Janin et al., 2003), comprised of 72 hours of meeting recordings with an average of 6 speakers per meeting, with associated transcripts, has spurred further annotations for various types of information, including dialog acts (Shriberg et al., 2004), topic hierarchies and action items (Gruenstein et al., 2005), and “hot spots” (Wrede and Shriberg, 2003).
W04-2319
“Let’s have the paper written by next Tuesday”— we use Identifinder (Bikel et al., 1997) to mark temporal expressions (“TIMEX” tags) in utterance transcripts, and create a binary feature denoting 99 the existence of a temporal expression in each utterance.
A97-1029
(Shriberg et al., 2004) As these DA annotations do not correspond one-to-one with utterances in the ICSI corpus, we align them in the most liberal way possible, i.e., if at least one word in an utterance is annotated for a particular DA, we mark the entirety of that utterance as exhibiting that DA.
W04-2319
Cohen et al.(2004).) In the audio domain, annotations for action item utterances on several recorded meeting corpora, including the ICSI corpus, have recently become available (Gruenstein et al., 2005), enabling work on this topic.
W04-3240
We apply a maximum entropy (maxent) model (Berger et al., 1996) to this task.
J96-1002
features Under the hypothesis that action item utterances will exhibit particular syntactic patterns, we use a conditional Markov model part-of-speech (POS) tagger (Toutanova and Manning, 2000) trained on the Switchboard corpus (Godfrey et al., 1992) to tag utterance words for part of speech.
W00-1308
Inter-annotator agreement is typically measured by the kappa statistic (Carletta, 1996), dekappa frequency 0.0 0.2 0.4 0.6 0.8 1.0 0 2 4 6 8 Figure 2: Distribution of κ (inter-annotator agreement) across the 54 ICSI meetings tagged by two annotators.
J96-2004
96 Research on DA classification initially focused on two-party conversational speech (Mast et al., 1996; Stolcke et al., 1998; Shriberg et al., 1998) and, more recently, has extended to multi-party audio recordings like the ICSI corpus (Shriberg et al., 2004).
W04-2319
