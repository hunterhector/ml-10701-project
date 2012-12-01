The consistency and magnitude of the first three parser metrics, however, lends support to the idea of Wan et al.(2005) to use something like these as indicators of generated sentence fluency.
W05-1628
Supertag This is a variant of the approach above, but using supertags (Bangalore and Joshi, 1999) instead of PoS tags.
J99-2004
In terms of automatic evaluation, we are not aware of any technique that measures only fluency or similar characteristics, ignoring content, apart from that of Wan et al.(2005). Even in NLG, where, given the variability of the input representations (and hence difficulty in verifying faithfulness), it might be expected that such measures would be available, the available metrics still conflate content and form.
W05-1628
Quite a different idea was suggested in Wan et al.(2005), of using the grammatical judgement of a parser to assess fluency, giving a measure independent of the language model used to generate the text.
W05-1628
For example, the metrics proposed in Bangalore et al.(2000), such as Simple Accuracy and Generation Accuracy, measure changes with respect to a reference string based on the idea of string-edit distance.
W00-1401
As a further contrast, the analysis of Coch (1996) was very comprehensive and fine-grained, in a comparison of three text-production techniques: he used 14 human judges, each judging 60 letters (20 per generation system), and required them to assess the letters for correct spelling, good grammar, rhythm and flow, appropriateness of tone, and several other specific characteristics of good text.
C96-1043
6We used the supertagger of Bangalore and Joshi (1999).
J99-2004
This is a phenomenon seen in MT, where BLEU seems to favour text that has been produced using a similar statistical n-gram language model over other symbolic models (Callison-Burch et al., 2006).
E06-1032
BLEU (Papineni et al., 2002) is a canonical example: in matching n-grams in a candidate translation text with those in a reference text, the metric measures faithfulness by counting the matches, and fluency by implicitly using the reference n-grams as a language model.
P02-1040
