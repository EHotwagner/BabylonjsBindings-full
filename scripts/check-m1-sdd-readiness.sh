#!/usr/bin/env bash
set -euo pipefail

ROOT="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
WORK_ID="003-m1-exact-projections-collisions"
READINESS="$ROOT/readiness/$WORK_ID"

jq -e '
  .schemaVersion == 1 and
  .workId == "003-m1-exact-projections-collisions" and
  .status == "shipReady" and
  .readiness == "shipReady" and
  .generator == "FS.GG.SDD.Artifacts/1.5.0" and
  (.sourcesDigest.algorithm == "sha256") and
  (.sourcesDigest.value | test("^[0-9a-f]{64}$")) and
  .verificationReadiness.status == "verificationReady" and
  .verificationReadiness.evidenceSupportedCount == 10 and
  .verificationReadiness.evidenceSelfAttestedCount == 0 and
  .verificationReadiness.evidenceObservedCount == 10 and
  .disposition.state == "shipReady" and
  (.disposition.blockingFindingIds | length) == 0
' "$READINESS/ship-verdict.json" >/dev/null

printf '%s\n' '{"workId":"003-m1-exact-projections-collisions","verification":"verificationReady","supported":10,"observed":10,"selfAttested":0,"synthetic":0,"ship":"shipReady","blockingFindings":0,"durableVerdict":"readiness/003-m1-exact-projections-collisions/ship-verdict.json"}'
